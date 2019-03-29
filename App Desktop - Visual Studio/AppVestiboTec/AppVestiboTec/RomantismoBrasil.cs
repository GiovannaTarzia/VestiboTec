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
    public partial class RomantismoBrasil : Form
    {
        public RomantismoBrasil()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
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

        private void classicismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classicismo abre = new Classicismo();
            abre.ShowDialog();
        }

        private void romantismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void noBrasilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void emPortugalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RomantismoPortugal abre = new RomantismoPortugal();
            abre.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void fuvestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExerciciosFuvest abre = new ExerciciosFuvest();
            abre.ShowDialog();
        }

        private void visãoGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romantismo Abre = new Romantismo();
            Abre.ShowDialog();
        }
    }
}
