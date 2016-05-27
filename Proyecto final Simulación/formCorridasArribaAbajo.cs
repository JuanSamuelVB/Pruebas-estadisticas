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
    public partial class formCorridasArribaAbajo : Form
    {
        public formCorridasArribaAbajo()
        {
            InitializeComponent();
        }

        void limpiarForma()
        {
            lblDesviacion.Text = "Desviación";
            lblH.Text = "H";
            lblMedia.Text = "Media";
            lblN1.Text = "N1";
            lblN2.Text = "N2";
            lblZ.Text = "Z0";
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

        void pruebaCorridas(List<double> Xi)
        {
            int R, N1, N2;
            double Media, Desviacion, H, Z0;
            List<bool> Arriba = new List<bool>();
            
            // Ver si estan arriba o abajo
            foreach (double x in Xi)
            {
                if (x < 0.5)
                {
                    Arriba.Add(false);
                }
                else
                {
                    Arriba.Add(true);
                }
            }

            R = numDeCorridas(Arriba);
            N1 = Arriba.FindAll(x => x == false).Count;
            N2 = Arriba.FindAll(x => x == true).Count;

            // Calcular media
            Media = 2 * N1 * N2;
            Media = Media / (N1 + N2);
            Media = Media + 1;

            // Calcular desviacion
            Desviacion = (2 * N1 * N2) - N1 - N2;
            Desviacion = 2 * N1 * N2 * Desviacion;
            Desviacion = Desviacion / (Math.Pow(N1 + N2, 2) * (N1 + N2 - 1));
            Desviacion = Math.Sqrt(Desviacion);

            // Corrección para continuidad
            H = R < Media ? 0.5 : -0.5;

            // Valor estadístico Z0
            Z0 = R + H - Media;
            Z0 = Z0 / Desviacion;

            lblR.Text = "R = " + R.ToString();
            lblN1.Text = "N1 = " + N1.ToString();
            lblN2.Text = "N2 = " + N2.ToString();
            lblMedia.Text = "Media = " + Media.ToString();
            lblDesviacion.Text = "Desviacion = " + Desviacion.ToString();
            lblH.Text = "H = " + H.ToString();
            lblZ.Text = "Z0 = " + Z0.ToString();

            if (Z0 < -1.96)
            {
                lblResultado.Text = "Resultado\nZ0 < -1.96\n∴\nNo se comportan de manera aleatoria.";
            }
            else if (Z0 > 1.96)
            {
                lblResultado.Text = "Resultado\n1.96 < Z0\n∴\nNo se comportan de manera aleatoria.";
            }
            else
            {
                lblResultado.Text = "Resultado\n-1.96 ≤ Z0 ≤ 1.96\n∴\nSe comportan de manera aleatoria.";
            }
        }

        int numDeCorridas(List<bool> arriba)
        {
            int num = 0;
            bool anteriorEsArriba = false;

            for (int i = 0; i < arriba.Count; i++)
            {
                if (i == 0)
                {
                    num++;
                    anteriorEsArriba = arriba[i];
                }
                else
                {
                    if (arriba[i] != anteriorEsArriba)
                    {
                        num++;
                        anteriorEsArriba = arriba[i];
                    }
                }
            }

            return num;
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
            pruebaCorridas(Xi);
        }
    }
}
