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
    public partial class Fuvest : Form
    {
        public Fuvest()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void unicampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Unicamp Abre = new Unicamp();
            Abre.ShowDialog();
        }

        private void classicismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classicismo Abre = new Classicismo();
            Abre.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Fuvest_Load(object sender, EventArgs e)
        {

        }

        private void romantismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void visãoGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romantismo Abre = new Romantismo();
            Abre.ShowDialog();
        }
    }
}
