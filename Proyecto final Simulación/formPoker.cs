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
    public partial class formPoker : Form
    {
        string[] Clasificacion = new string[7] { "Todos diferentes", "Un par", "Dos pares", "Tercia", "Full", "Poker", "Quintilla" };
        double[] P = new double[7] { 0.3024, 0.5040, 0.1080, 0.0720, 0.0090, 0.0045, 0.001 };

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

        void limpiarForma()
        {
            dgvTabla.Rows.Clear();
            lblN.Text = "";
            lblX2.Text = "X2";
            lblXam.Text = "X(α, n-1)";
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

        void pruebaPoker(List<double> Xi)
        {
            int[] FOi1 = new int[7];
            List<double> FEi1 = new List<double>();

            // Columnas
            List<double> FOi = new List<double>();
            List<double> FEi = new List<double>();
            List<double> X2i = new List<double>();

            int n = Xi.Count;

            // Columna preliminar de frecuencia observada
            foreach (double x in Xi)
            {
                FOi1[clasificarNumero(x)]++;
            }

            // Columna preliminar de frecuencia esperada
            foreach (double p in P)
            {
                FEi1.Add(p * n);
            }

            //bool mayorACinco = false;
            //int sumaDeFO = 0;
            //int iterador = FOi1.Length - 1;
            //while (!mayorACinco)
            //{
            //    if (sumaDeFO > 5)
            //    {
            //        mayorACinco = true;
            //    }
            //    else
            //    {
            //        sumaDeFO += FOi1[iterador];
            //        iterador--;
            //    }
            //}

            // Columna de X2i
            for (int i = 0; i < P.Length; i++)
            {
                double X2 = Math.Pow(FOi1[i] - FEi1[i], 2);
                X2 = X2 / FEi1[i];

                X2i.Add(X2);
            }

            // Resultado final
            double SumaX2i = 0;
            foreach (double x in X2i)
            {
                SumaX2i += x;
            }

            // Mostrar en DataGridView
            for (int i = 0; i < FOi1.Length; i++)
            {
                dgvTabla.Rows.Add(Clasificacion[i], FOi1[i], FEi1[i], X2i[i]);
            }

            double a = double.Parse((string)cmbAlpha.SelectedItem);

            lblN.Text = "n = " + n.ToString();
            lblX2.Text = "X2 = " + SumaX2i.ToString();

            double Xan = X(a, FOi1.Length - 1);

            if (Xan >= 0)
            {
                lblXam.Text = "X(" + a.ToString() + ", " + n.ToString() + ") = " + Xan.ToString();

                if (SumaX2i < Xan)
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

        int clasificarNumero(double n)
        {
            string num5caracteres = obtener5Caracteres(n);
            Dictionary<char, int> frecNum = contarNumeros(num5caracteres);

            int numPares = 0;
            int numTercias = 0;
            foreach (KeyValuePair<char, int> f in frecNum)
            {
                if (f.Value == 5)
                {
                    return 6;
                }
                else if (f.Value == 4)
                {
                    return 5;
                }
                else if (f.Value == 3)
                {
                    numTercias++;
                }
                else if (f.Value == 2)
                {
                    numPares++;
                }
            }

            if (numPares == 1 && numTercias == 1)
            {
                return 4;
            }
            else if (numTercias == 1)
            {
                return 3;
            }
            else if (numPares == 2)
            {
                return 2;
            }
            else if (numPares == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        string obtener5Caracteres(double n)
        {
            string numstring = n.ToString("#.00000");

            return numstring.Substring(1);
        }

        Dictionary<char, int> contarNumeros(string n)
        {
            Dictionary<char, int> FrecNum = new Dictionary<char, int>()
            {
                { '0', 0 },
                { '1', 0 },
                { '2', 0 },
                { '3', 0 },
                { '4', 0 },
                { '5', 0 },
                { '6', 0 },
                { '7', 0 },
                { '8', 0 },
                { '9', 0 }
            } ;

            foreach (char c in n)
            {
                FrecNum[c]++;
            }

            return FrecNum;
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
            pruebaPoker(Xi);
        }
    }
}
