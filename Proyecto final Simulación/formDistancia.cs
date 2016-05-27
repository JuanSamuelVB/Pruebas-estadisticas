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
    public partial class formDistancia : Form
    {
        public formDistancia()
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

        void pruebaDistancia(List<double> Xi)
        {
            List<bool> Adentro = new List<bool>();
            Dictionary<int, int> FO = new Dictionary<int, int>();
            double LI = (double)nudLI.Value;
            double LS = (double)nudLS.Value;
            int n = (int)nudN.Value;

            // Columnas
            //List<int> i = new List<int>();
            List<double> Pi = new List<double>();
            List<double> FOi = new List<double>();
            List<double> FEi = new List<double>();
            List<double> X2i = new List<double>();

            double Theta = LS - LI;

            // Calcular columna Pi
            for (int i = 0; i < n; i++)
            {
                Pi.Add(Theta * Math.Pow((1 - Theta), i));
            }
            Pi.Add(Math.Pow((1 - Theta), n));

            // Ver si estan dentro del rango
            foreach (double x in Xi)
            {
                if (x > LI && x < LS)
                {
                    Adentro.Add(true);
                }
                else
                {
                    Adentro.Add(false);
                }
            }

            lblMarcas.Text = "";
            foreach (bool aden in Adentro)
            {
                lblMarcas.Text += (aden ? "✔" : "✘");
            }

            // Crear categorias para contar distancias
            for (int i = 0; i <= n; i++)
            {
                FO.Add(i, 0);
            }

            // Contar distancias
            bool anteriorEsAdentro = false;
            int contadorDeAfueras = 0;
            for (int i = 0; i < Adentro.Count; i++)
            {
                if (Adentro[i])
                {
                    if (!anteriorEsAdentro)
                    {
                        if (i != 0)
                        {
                            if (contadorDeAfueras >= n)
                            {
                                FO[n]++;
                                contadorDeAfueras = 0;
                            }
                            else
                            {
                                FO[contadorDeAfueras]++;
                                contadorDeAfueras = 0;
                            }
                        }
                        anteriorEsAdentro = true;
                    }
                }
                else
                {
                    if (anteriorEsAdentro)
                    {
                        if (i != 0)
                        {
                            FO[0]++;
                        }
                        anteriorEsAdentro = false;
                    }

                    contadorDeAfueras++;
                }

                if (i == Adentro.Count - 1)
                {
                    if (Adentro[i])
                    {
                        FO[0]++;
                    }
                    else
                    {
                        if (contadorDeAfueras >= n)
                        {
                            FO[n]++;
                            contadorDeAfueras = 0;
                        }
                        else
                        {
                            FO[contadorDeAfueras]++;
                            contadorDeAfueras = 0;
                        }
                    }
                }
            }

            // Suma de FO
            int SumaFO = 0;
            foreach (KeyValuePair<int, int> par in FO)
            {
                SumaFO += par.Value;
            }

            // Columna de frecuencia esperada
            for (int i = 0; i <= n; i++)
            {
                FEi.Add(SumaFO * Pi[i]);
            }

            // Columna de X2i
            for (int i = 0; i <= n; i++)
            {
                double X2 = Math.Pow(FO[i] - FEi[i], 2);
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
            for (int i = 0; i <= n; i++)
            {
                dgvTabla.Rows.Add(i, Pi[i], FO[i], FEi[i], X2i[i]);
            }

            double a = Double.Parse((string)cmbAlpha.SelectedItem);
            

            lblTheta.Text = "θ = " + Theta.ToString();
            lblSumaFO.Text = "Suma de FO = " + SumaFO.ToString();
            lblX2.Text = "X2 = " + SumaX2i.ToString();

            double Xam = X(a, n);

            if (Xam >= 0)
            {
                lblXam.Text = "X(" + a.ToString() + ", " + n.ToString() + ") = " + Xam.ToString();

                if (SumaX2i < Xam)
                {
                    lblResultado.Text = "Resultado\nX2 < X(α, m)\n∴\nEs una distribución independiente";
                }
                else
                {
                    lblResultado.Text = "Resultado\nX2 > X(α, m)\n∴\nNo es una distribución independiente";
                }
            }
            else
            {
                MessageBox.Show("Valor X(" + a.ToString() + ", " + n.ToString() + ") no encontrado");
            }
        }

        void limpiarForma()
        {
            dgvTabla.Rows.Clear();
            lblTheta.Text = "θ";
            lblMarcas.Text = "";
            lblSumaFO.Text = "Suma de FO";
            lblX2.Text = "X2";
            lblXam.Text = "X(α, m)";
            lblResultado.Text = "";
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
            pruebaDistancia(Xi);
        }
    }
}
