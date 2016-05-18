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
    }
}
