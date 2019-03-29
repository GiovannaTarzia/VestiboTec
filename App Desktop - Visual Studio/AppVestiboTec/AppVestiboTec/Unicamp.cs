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
    public partial class Unicamp : Form
    {
        public Unicamp()
        {
            InitializeComponent();
        }

        private void negrinhaLivroNegrinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fuvestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fuvest abre = new Fuvest();
            abre.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Unicamp_Load(object sender, EventArgs e)
        {

        }

        private void classicismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classicismo abre = new Classicismo();
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

        private void realismoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
