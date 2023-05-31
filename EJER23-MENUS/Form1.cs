using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJER24_LISTASII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lISTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especificaciones especificaciones = new Especificaciones();
            especificaciones.ShowDialog();
        }

        private void fORMATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mini_Procesador mini_Procesador = new Mini_Procesador();
            mini_Procesador.ShowDialog();
        }
    }
}