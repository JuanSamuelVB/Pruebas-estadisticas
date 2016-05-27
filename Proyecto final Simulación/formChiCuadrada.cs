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
    public partial class formChiCuadrada : Form
    {
        public formChiCuadrada()
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

        void limpiarForma()
        {
            lblX2.Text = "X2";
            lblXam.Text = "X(α, m-1)";
            dgvTabla.Rows.Clear();
            lblResultado.Text = "";
        }

        List<double> obtenerNumeros()
        {
            List<double> Xi = new List<double>();
            string ruta = txtArchivo.Text;

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

        double X(double a, int n)
        {
            string[][] tabla = obtenerTablaChi();

            int columna = -1;

            for (int i = 0; i < tabla[0].Length; i++)
            {
                if (tabla[0][i] == n.ToString())
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

            if (columna >= 0)
            {
                if (tabla[fila][columna] == "")
                {
                    resultado = -1;
                }
                else
                {
                    resultado = Double.Parse(tabla[fila][columna]);
                }
            }
            else
            {
                resultado = -1;
            }

            return resultado;
        }

        void pruebaChiCuadrada(List<double> Xi)
        {
            // Columnas
            List<int> ii = new List<int>();
            List<string> mi = new List<string>();
            List<int> FOi = new List<int>();
            List<double> FEi = new List<double>();
            List<double> X2i = new List<double>();

            int m = (int)Math.Truncate((Math.Sqrt(Xi.Count)));
            double tamIntervalo = 1f / m;
            List<double> limSupIntervalos = new List<double>();

            for (int i = 1; i <= m; i++)
            {
                ii.Add(i);
                limSupIntervalos.Add(tamIntervalo * i);
                mi.Add(String.Format("{0}-{1}", tamIntervalo * i - tamIntervalo, tamIntervalo * i));
                FOi.Add(0);
                FEi.Add((float)Xi.Count / (float)m);
            }

            foreach (double x in Xi)
            {
                for (int i = 0; i < m; i++)
                {
                    double limInf = limSupIntervalos[i] - tamIntervalo;
                    if (limInf < x && x < limSupIntervalos[i])
                    {
                        FOi[i]++;
                    }
                }
            }

            // Columna de X2i
            for (int i = 0; i < m; i++)
            {
                double X2 = Math.Pow(FOi[i] - FEi[i], 2);
                X2 = X2 / FEi[i];

                X2i.Add(X2);
            }

            // Resultado final
            double SumaX2i = 0;
            foreach (double x in X2i)
            {
                SumaX2i += x;
            }

            // Mostrar en DataGridView
            for (int i = 0; i < ii.Count; i++)
            {
                dgvTabla.Rows.Add(ii[i], mi[i], FOi[i], FEi[i], X2i[i]);
            }

            lblM.Text = "m = " + m.ToString();
            lblX2.Text = "X2 = " + SumaX2i.ToString();

            double a = double.Parse((string)cmbAlpha.SelectedItem);
            double Xan = X(a, m - 1);

            if (Xan >= 0)
            {
                lblXam.Text = "X(" + a.ToString() + ", " + (m - 1).ToString() + ") = " + Xan.ToString();

                if (SumaX2i < Xan)
                {
                    lblResultado.Text = "Resultado\nX2 < X(α, m-1)\n∴\nEs una distribución independiente";
                }
                else
                {
                    lblResultado.Text = "Resultado\nX2 > X(α, m-1)\n∴\nNo es una distribución independiente";
                }
            }
            else
            {
                MessageBox.Show("Valor X(" + a.ToString() + ", " + (m-1).ToString() + ") no encontrado");
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
                txtArchivo.Text = dialogo.FileName;
                btnHacerPrueba.Enabled = true;
            }
        }

        private void btnHacerPrueba_Click(object sender, EventArgs e)
        {
            limpiarForma();
            List<double> Xi = obtenerNumeros();
            pruebaChiCuadrada(Xi);
        }
    }
}
