﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class MenuForm : Form
    {
        int contador = 0;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardadoForm guardado = new GuardadoForm();
            if (contador < 9)
            {
                guardado.ShowDialog();
            }   
            EditorDeTexto cuaderno = new EditorDeTexto();
            this.Hide();
            cuaderno.Show();
        }
    }
}
