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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void métodoCongruencialMixtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCongruencialMixto fcm = new formCongruencialMixto();
            fcm.Show();
        }

        private void kolmogorovSmirnovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formKolmogorovSmirnov fks = new formKolmogorovSmirnov();
            fks.Show();
        }

        private void kolmogorovSmirnovToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formTabla ft = new formTabla(formTabla.Tabla.KS);
            ft.Show();
        }

        private void distanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDistancia fd = new formDistancia();
            fd.Show();
        }

        private void chicuadradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTabla ft = new formTabla(formTabla.Tabla.Chi);
            ft.Show();
        }

        private void pókerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPoker fp = new formPoker();
            fp.Show();
        }

        private void corridasArribaYDebajoDeLaMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCorridasArribaAbajo fcaa = new formCorridasArribaAbajo();
            fcaa.Show();
        }

        private void chicuadradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formChiCuadrada fcc = new formChiCuadrada();
            fcc.Show();
        }
    }
}
