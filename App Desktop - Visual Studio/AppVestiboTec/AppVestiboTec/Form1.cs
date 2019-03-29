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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void fuvestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fuvest AbreF = new Fuvest();
            AbreF.ShowDialog();
        }

        private void unicampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unicamp AbreU = new Unicamp();
            AbreU.ShowDialog();
        }

        private void classicismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classicismo Abre = new Classicismo();
            Abre.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void luizDeCamõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void romantismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void emPortugalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RomantismoPortugal abre = new RomantismoPortugal();
            abre.ShowDialog();
        }

        private void fuvesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExerciciosFuvest abre = new ExerciciosFuvest();
            abre.ShowDialog();
        }

        private void noBrasilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RomantismoBrasil abre = new RomantismoBrasil();
            abre.ShowDialog();
        }

        private void visãoGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romantismo Abre = new Romantismo();
            Abre.ShowDialog();
        }
    }
}
