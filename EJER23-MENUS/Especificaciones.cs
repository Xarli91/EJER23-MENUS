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
    public partial class Especificaciones : Form
    {
        public Especificaciones()
        {
            InitializeComponent();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nombre nombre = new Nombre();
            nombre.ShowDialog();
        }

        private void eliminarSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItems);
        }

        private void eliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
