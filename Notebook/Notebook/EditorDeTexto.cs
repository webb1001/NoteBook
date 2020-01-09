using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notebook
{
    //Para solucionar lo de escribir las lineas del texto otra vez cada vez que guardamos lo que hay que hacer es traer 
    //la variable campo[] y cuando guardamos sobreescribir lo que esta guardado en ella.
    public partial class EditorDeTexto : Form
    {
        StreamReader lector;
        StreamWriter escritor;
        string nombreUsuario;
        string cadena;
        string[] campos = new string[47];
        char[] separador = { '°' };
        int numeroCuaderno = 0;
        public EditorDeTexto(string nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
            InitializeComponent();
        }
        public EditorDeTexto(string nombreUsuario,int numeroCuaderno)
        {
            this.nombreUsuario = nombreUsuario;
            this.numeroCuaderno = numeroCuaderno;
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

        //private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (numeroCuaderno == 0)
        //    {
        //        escritor = File.AppendText(nombreUsuario + ".txt");
        //        escritor.WriteLine(PaginaRichTextBox.Text);
        //        escritor.Close();
        //    }
        //    else
        //    {
        //        SobreescribirArchivo(numeroCuaderno-1);
        //    }
        //}

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeerArchivo();
            if (numeroCuaderno == 0)
            {
                LeerArchivo();
                escritor = File.AppendText(nombreUsuario + ".txt");
                escritor.WriteLine(PaginaRichTextBox.Text);
                numeroCuaderno++;
                escritor.Close();
            }
            else
            {
                LeerArchivo();
                SobreescribirArchivo(numeroCuaderno - 1);
            }
        }

        //private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    DialogResult cerrar = MessageBox.Show("¿Desea guardar antes de salir?", "Confirmación", MessageBoxButtons.YesNo);
        //    if (cerrar == DialogResult.Yes)
        //    {
        //        if (numeroCuaderno == 0)
        //        {
        //            escritor = File.AppendText(nombreUsuario + ".txt");
        //            escritor.WriteLine(PaginaRichTextBox.Text);
        //            escritor.Close();
        //            this.Hide();
        //        }
        //        else
        //        {
        //            SobreescribirArchivo(numeroCuaderno-1);
        //        }
        //    }
        //    if (cerrar == DialogResult.No)
        //    {
        //        this.Hide();
        //    }
        //    MenuForm estanteria1 = new MenuForm(nombreUsuario);
        //    estanteria1.Show();
        //}

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeerArchivo();
            DialogResult cerrar = MessageBox.Show("¿Desea guardar antes de salir?", "Confirmación", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)
            {
                if (numeroCuaderno == 0)
                {
                    escritor = File.AppendText(nombreUsuario + ".txt");
                    escritor.WriteLine(PaginaRichTextBox.Text);
                    escritor.Close();
                    this.Hide();
                }
                else
                {
                    SobreescribirArchivo(numeroCuaderno - 1);
                }
            }
            if (cerrar == DialogResult.No)
            {
                this.Hide();
            }
            MenuForm estanteria1 = new MenuForm(nombreUsuario);
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

        private void EditorDeTexto_Load(object sender, EventArgs e)
        {
            LeerArchivo();
            if(numeroCuaderno != 0)
            {
                CargarArchivo(numeroCuaderno-1);
            }
        }

        public void CargarArchivo(int numeroCuaderno)
        {
            PaginaRichTextBox.Text = campos[numeroCuaderno * 4 + 5].Trim().ToString();
        }
        public void LeerArchivo()
        {
            try
            {
                lector = File.OpenText(nombreUsuario + ".txt");
                cadena = lector.ReadToEnd();
                campos = cadena.Split(separador);
                lector.Close();
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show("Error" + fe.Message);
            }
            catch (Exception en)
            {
                MessageBox.Show("Error" + en.Message);
            }
        }
        public void SobreescribirArchivo(int numeroCuaderno)
        {
            LeerArchivo();
            File.Delete(nombreUsuario + ".txt");
            StreamWriter escritor = new StreamWriter(nombreUsuario + ".txt");
            //int aux = Convert.ToInt32(campos[1]);
            //aux++;
            //campos[1] = Convert.ToString(aux);
            campos[numeroCuaderno * 4 + 5] = PaginaRichTextBox.Text;
            for(int i = 0; i < campos.Length; i++)
            {
                if (i == campos.Length - 1)
                {
                    campos[i] = campos[i];
                    escritor.Write(campos[i]);
                }
                else
                {
                    campos[i] = campos[i] + "°";
                    escritor.Write(campos[i]);
                }
            }
            escritor.Close();
        }
    }
}
