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
    public partial class formCongruencialMixto : Form
    {
        List<double> Xi = new List<double>();
        List<double> ri = new List<double>();

        public formCongruencialMixto()
        {
            InitializeComponent();
            numA.Maximum = Decimal.MaxValue;
            numC.Maximum = Decimal.MaxValue;
            numX0.Maximum = Decimal.MaxValue;
            numM.Maximum = Decimal.MaxValue;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            double a = (float)numA.Value;
            double c = (float)numC.Value;
            double X0 = (float)numX0.Value;
            double m = (float)numM.Value;
            double Xn = X0;
            double Xn1;
            double r;
            int n = 0;
            bool PeriodoTerminado;
            Xi = new List<double>();
            ri = new List<double>();
            
            Xi.Add(X0);
            
            do
            {
                Xn1 = (a * Xn + c) % m;
                r = Xn1 / m;

                if (!(PeriodoTerminado = Xi.Contains(Xn1)))
                {
                    Xi.Add(Xn1);
                    ri.Add(r);

                    dataGridView1.Rows.Add(n, Xn, "((" + a.ToString() + ")*(" + Xn.ToString() + ") + " + c.ToString() + ") mod " + m.ToString(), Xn1, r);

                    Xn = Xn1;

                    n++;
                }
            } while (!PeriodoTerminado);
            
            txtPeriodo.Text = n.ToString();
        }

        private void numA_Enter(object sender, EventArgs e)
        {
            numA.Select(0, numA.Text.Length);
        }

        private void numC_Enter(object sender, EventArgs e)
        {
            numC.Select(0, numC.Text.Length);
        }

        private void numX0_Enter(object sender, EventArgs e)
        {
            numX0.Select(0, numX0.Text.Length);
        }

        private void numM_Enter(object sender, EventArgs e)
        {
            numM.Select(0, numM.Text.Length);
        }

        private void btnExpNums_Click(object sender, EventArgs e)
        {
            // Dialogo para guardar
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Comma-separated values (*.csv)|*.csv|JSON (*.json)|*.json|All(*.*)|*"
            };

            // Guardar con la dirección obtenida con el dialogo
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(dialog.FileName);
                string salida;

                if (extension.ToLower() == ".json")
                {
                    salida = JsonConvert.SerializeObject(ri);
                }
                else
                {
                    salida = ri[0].ToString();
                    for (int i = 1; i < ri.Count; i++)
                    {
                        salida += "," + ri[i].ToString();
                    }
                }

                File.WriteAllText(dialog.FileName, salida);
            }
        }
    }
}
