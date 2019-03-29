using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVestiboTec
{
    public partial class Classicismo : Form
    {
        public Classicismo()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void fuvestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fuvest abre = new Fuvest();
            abre.ShowDialog();
        }

        private void unicampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unicamp abre = new Unicamp();
            abre.ShowDialog();
        }

        private void romantismoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextoHistóricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romantismo Abre = new Romantismo();
            Abre.ShowDialog();
        }
    }
}
