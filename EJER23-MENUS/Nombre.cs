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
    public partial class Nombre : Form
    {
        public Nombre()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Especificaciones especificaciones = new Especificaciones();
            especificaciones.listBox1.Items.Add(textBox1);
        }
    }
}
