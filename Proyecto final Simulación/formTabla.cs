using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Proyecto_final_Simulación
{
    public partial class formTabla : Form
    {
        public enum Tabla { KS, Chi }

        Tabla tipotabla;

        public formTabla(Tabla t)
        {
            InitializeComponent();
            this.tipotabla = t;

            // Dibujar DataGridView con doble buffer para mejor funcionamiento
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
                BindingFlags.Instance | BindingFlags.SetProperty, null,
                dataGridView1, new object[] { true });

            if (this.tipotabla == Tabla.KS)
            {
                InicializarKS();
            }
            else if (this.tipotabla == Tabla.Chi)
            {
                InicializarChi();
            }
        }

        void InicializarKS()
        {
            this.Text = "Tabla Kolmogorov-Smirnov";
            dataGridView1.Rows.Clear();

            //string[] lineas = Properties.Resources.Tabla_KS.Split('\n');
            string[] lineas = Properties.Settings.Default.TablaKS.Split('\n');

            // Eliminar lineas vacias
            lineas = lineas.Where(linea => !(string.IsNullOrEmpty(linea) || linea == "\r")).ToArray();

            string[][] tabla = new string[lineas.Length][];


            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = lineas[i].Split(',');
            }

            foreach (string columna in tabla[0])
            {
                dataGridView1.Columns.Add(columna, columna);
            }
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 1; i < tabla.Length; i++)
            {
                dataGridView1.Rows.Add(tabla[i]);
            }
        }

        void InicializarChi()
        {
            this.Text = "Tabla de chi-cuadrada";
            dataGridView1.Rows.Clear();

            // TODO
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string salida = "";

            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                // Si no es la ultima columna
                if (columna != dataGridView1.Columns[dataGridView1.Columns.Count - 1])
                {
                    salida += columna.Name + ",";
                }
                // Ultima columna
                else
                {
                    salida += columna.Name;
                }
            }
            salida += "\n";

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewCell celda in dataGridView1.Rows[i].Cells)
                {
                    // Si no esta en la ultima columna
                    if (celda != dataGridView1.Rows[i].Cells[dataGridView1.Rows[i].Cells.Count - 1])
                    {
                        salida += celda.Value + ",";
                    }
                    // Ultima columna
                    else
                    {
                        salida += celda.Value;
                    }
                }

                salida += "\n";
            }

            if (tipotabla == Tabla.KS)
            {
                Properties.Settings.Default.TablaKS = salida;
            }

            Properties.Settings.Default.Save();

            MessageBox.Show("Los cambios han sido guardados.", "Guardar tabla");
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Se remplazará la tabla actual con la tabla predeterminada.\n" +
                                                "¿Desea continuar?", "Restaurar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Properties.Settings.Default.TablaKS = Properties.Settings.Default.TablaKSDefault;
            }

            Properties.Settings.Default.Save();

            if (tipotabla == Tabla.KS)
            {
                InicializarKS();
            }
            else if (tipotabla == Tabla.Chi)
            {
                InicializarChi();
            }
        }
    }
}
