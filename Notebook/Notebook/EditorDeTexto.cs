using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notebook.UNA.Cuaderno;

namespace Notebook
{
    public partial class EditorDeTexto : Form
    {
        public EditorDeTexto()
        {
            InitializeComponent();
        }
        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formato = fontDialog1.ShowDialog();
            if(formato == DialogResult.OK)
            {
                PaginaRichTextBox.Font = fontDialog1.Font;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GuardadoForm guardado = new GuardadoForm();
            //if ()guardado.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("¿Desea guardar antes de salir?", "Confirmación", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)
            {
                //Aqui va el codigo para guardar...
            }
            if (cerrar == DialogResult.No)
            {
                this.Hide();
            }
            MenuForm estanteria1 = new MenuForm();
            estanteria1.Show();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaRichTextBox.Undo();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaRichTextBox.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaRichTextBox.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaRichTextBox.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaRichTextBox.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaRichTextBox.SelectAll();
        }

        private void eliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaRichTextBox.Clear();
         }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c1 = colorDialog1.ShowDialog();
            if (c1 == DialogResult.OK)
            {
                PaginaRichTextBox.ForeColor = colorDialog1.Color;
            }
        }
    }
}
