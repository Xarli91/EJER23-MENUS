using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJER24_LISTASII
{
    public partial class Mini_Procesador : Form
    {
        public Mini_Procesador()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial",12);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 14);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 16);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 18);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 20);
        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
        }

        private void cursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
        }

        private void subrayadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font, FontStyle.Underline);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 12);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 14);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 16);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 18);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 20);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
