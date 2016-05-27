using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_Simulación
{
    public partial class formPoker : Form
    {
        public formPoker()
        {
            InitializeComponent();

            string[][] tabla = obtenerTablaChi();

            for (int i = 1; i < tabla.Length; i++)
            {
                if (tabla[i][0] != "")
                {
                    cmbAlpha.Items.Add(tabla[i][0]);
                }
            }

            cmbAlpha.SelectedItem = cmbAlpha.Items[0];
        }

        string[][] obtenerTablaChi()
        {
            string[] lineas = Properties.Settings.Default.TablaChi.Split('\n');

            // Eliminar lineas vacias
            lineas = lineas.Where(linea => !(string.IsNullOrEmpty(linea) || linea == "\r")).ToArray();

            string[][] tabla = new string[lineas.Length][];

            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = lineas[i].Split(',');
            }

            return tabla;
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog()
            {
                Filter = "Comma-separated values (*.csv)|*.csv|JSON (*.json)|*.json|All(*.*)|*"
            };

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.Text = dialogo.FileName;
                btnHacerPrueba.Enabled = true;
            }
        }
    }
}
