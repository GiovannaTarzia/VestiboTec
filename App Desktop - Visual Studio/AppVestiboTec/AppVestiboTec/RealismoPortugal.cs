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
    public partial class RealismoPortugal : Form
    {
        public RealismoPortugal()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RealismoPortugal_Load(object sender, EventArgs e)
        {

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

        private void classicismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classicismo abre = new Classicismo();
            abre.ShowDialog();
        }

        private void contextoHistóricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romantismo abre = new Romantismo();
            abre.ShowDialog();
        }

        private void noBrasilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RomantismoBrasil abre = new RomantismoBrasil();
            abre.ShowDialog();
        }

        private void emToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RomantismoPortugal abre = new RomantismoPortugal();
            abre.ShowDialog();
        }
    }
}
