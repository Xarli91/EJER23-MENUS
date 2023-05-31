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
    partial class Especificaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(83, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 104);
            this.listBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.eliminarSeleccionadoToolStripMenuItem,
            this.eliminarTodoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 100);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // eliminarSeleccionadoToolStripMenuItem
            // 
            this.eliminarSeleccionadoToolStripMenuItem.Name = "eliminarSeleccionadoToolStripMenuItem";
            this.eliminarSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.eliminarSeleccionadoToolStripMenuItem.Text = "Eliminar Seleccionado";
            this.eliminarSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarSeleccionadoToolStripMenuItem_Click);
            // 
            // eliminarTodoToolStripMenuItem
            // 
            this.eliminarTodoToolStripMenuItem.Name = "eliminarTodoToolStripMenuItem";
            this.eliminarTodoToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.eliminarTodoToolStripMenuItem.Text = "Eliminar Todo";
            this.eliminarTodoToolStripMenuItem.Click += new System.EventHandler(this.eliminarTodoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Especificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 277);
            this.Controls.Add(this.listBox1);
            this.Name = "Especificaciones";
            this.Text = "Palabra de Paso";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem añadirToolStripMenuItem;
        private ToolStripMenuItem eliminarSeleccionadoToolStripMenuItem;
        private ToolStripMenuItem eliminarTodoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        internal ListBox listBox1;
    }
}