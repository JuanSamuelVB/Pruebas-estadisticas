using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Proyecto_final_Simulación
{
    public partial class formKolmogorovSmirnov : Form
    {
        public formKolmogorovSmirnov()
        {
            InitializeComponent();

            string[][] tabla = obtenerTablaKS();

            for (int i = 1; i < tabla.Length; i++)
            {
                if (tabla[i][0] != "")
                {
                    cmbAlpha.Items.Add(tabla[i][0]);
                }
            }

            cmbAlpha.SelectedItem = cmbAlpha.Items[0];
        }

        private void btnHacerPrueba_Click(object sender, EventArgs e)
        {
            lblM.Text = "m";
            lblDm.Text = "Dm";
            lblDam.Text = "d(α, m)";

            try
            {
                List<double> Xi = obtenerNumeros();
                pruebaKS(Xi);
            }
            catch (FormatException)
            {
                MessageBox.Show("Archivo de números aleatorios no válido.", "Error");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Archivo de números aleatorios no válido.", "Error");
            }
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog()
            {
                Filter = "Comma-separated values (*.csv)|*.csv|JSON (*.json)|*.json|All(*.*)|*"
            };

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialogo.FileName;
                btnHacerPrueba.Enabled = true;
            }
        }

        double d(double a, int m)
        {
            string[][] tabla = obtenerTablaKS();

            int columna = tabla[0].Length - 1;

            for (int i = 0; i < tabla[0].Length; i++)
            {
                if (tabla[0][i] == m.ToString())
                {
                    columna = i;
                }
            }

            int fila = 0;

            for (int i = 0; i < tabla.Length; i++)
            {
                if (tabla[i][0] == a.ToString())
                {
                    fila = i;
                }
            }

            double resultado;

            if (tabla[fila][columna] == "")
            {
                resultado = -1;
            }
            else
            {
                if (columna == tabla[0].Length - 1)
                {
                    resultado = Double.Parse(tabla[fila][columna]) / Math.Sqrt(m);
                }
                else
                {
                    resultado = Double.Parse(tabla[fila][columna]);
                }
            }

            return resultado;
        }

        string[][] obtenerTablaKS()
        {
            string[] lineas = Properties.Settings.Default.TablaKS.Split('\n');

            // Eliminar lineas vacias
            lineas = lineas.Where(linea => !(string.IsNullOrEmpty(linea) || linea == "\r")).ToArray();

            string[][] tabla = new string[lineas.Length][];

            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = lineas[i].Split(',');
            }

            return tabla;
        }

        List<double> obtenerNumeros()
        {
            List<double> Xi = new List<double>();
            string ruta = textBox1.Text;

            if (Path.GetExtension(ruta).ToLower() == ".csv")
            {
                string texto = File.ReadAllText(ruta);

                foreach (string n in texto.Split(','))
                {
                    Xi.Add(Double.Parse(n));
                }
            }
            else if (Path.GetExtension(ruta).ToLower() == ".json")
            {
                string texto = File.ReadAllText(ruta);

                Xi = JsonConvert.DeserializeObject<List<double>>(texto);
            }

            return Xi;
        }

        void pruebaKS(List<double> Xi)
        {
            List<double> Fxi = new List<double>();
            List<double> Dm = new List<double>();

            Xi.Sort();

            int m = Xi.Count;

            for (int i = 1; i <= m; i++)
            {
                Fxi.Add((double)i / (double)m);
            }

            for (int i = 0; i < m; i++)
            {
                Dm.Add(Math.Abs(Fxi[i] - Xi[i]));
            }

            double a = Double.Parse((string)cmbAlpha.SelectedItem);

            lblM.Text = "m = " + m.ToString();
            lblDm.Text = "Dm = " + Dm.Max().ToString();

            double dam = d(a, m);

            if (dam == -1)
            {
                MessageBox.Show("Valor d(α, m) no encontrado.");
            }
            {
                lblDam.Text = "d(α, m) = " + dam.ToString();

                if (Dm.Max() > dam)
                {
                    lblResultado.Text = "Dm > d(α, m)  ∴  No están distribuidos uniformemente";
                }
                else
                {
                    lblResultado.Text = "Dm < d(α, m)  ∴  Están distribuidos uniformemente";
                }
            }
        }
    }
}
