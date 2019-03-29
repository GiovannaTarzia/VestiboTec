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
    public partial class Romantismo : Form
    {
        public Romantismo()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void classicismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classicismo Abre = new Classicismo();
            Abre.ShowDialog();
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

        private void fuvestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExerciciosFuvest abre = new ExerciciosFuvest();
            abre.ShowDialog();
        }

        private void emToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RomantismoPortugal abre = new RomantismoPortugal();
            abre.ShowDialog();
        }

        private void noBrasilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RomantismoBrasil abre = new RomantismoBrasil();
            abre.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void contextoHistóricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
