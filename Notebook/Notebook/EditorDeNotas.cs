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
    public partial class EditorDeNotas : Form
    {
        StreamReader lector;        //Permite leer los .txt
        StreamWriter escritor;       //Permite escribir en los .txt
        string nombreUsuario;       //Almacena el nombre de usuario
        string cadena;      //Se usa para almacenar el contenido del .txt
        string[] campos = new string[47];       //Mediante el caracter " ° " separa el contenido de cadena
        char[] separador = { '°' };     //Almacena el caracter usado como separador
        int idCuaderno = 0;     //Revise el numero del cuaderno que va a ser eeditado
        public EditorDeNotas()
        {
            InitializeComponent();
        }
        public EditorDeNotas(string nombreUsuario,int idCuaderno)
        {
            this.nombreUsuario = nombreUsuario;
            this.idCuaderno = idCuaderno;
            InitializeComponent();
        }
        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)     //Permite la edicion del formato de las notas
        {
            var formato = fontDialog1.ShowDialog();     //Abre un dialogo de formato
            if (formato == DialogResult.OK)     //Recibe una respuesta
            {
                PaginaRichTextBox.Font = fontDialog1.Font;      //Realiza los cambios en las notas
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)     //Guarda los cambios realizados en los cuadernos
        {
            LeerArchivo();
            if (idCuaderno == 0)        //Verifica que sea la primera vez que se escribe sobre este cuaderno
            {
                LeerArchivo();
                escritor = File.AppendText(nombreUsuario + ".txt");
                escritor.WriteLine(PaginaRichTextBox.Text);
                idCuaderno++;
                escritor.Close();
            }
            else        //En otro caso sobreescribe los cambios
            {
                LeerArchivo();
                SobreescribirArchivo(idCuaderno - 1);
            }
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)      //Cierra el editor de notas
        {
            LeerArchivo();
            DialogResult cerrar = MessageBox.Show("¿Desea guardar antes de salir?", "Confirmación", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)     //En caso que desee guardar cambios
            {
                if (idCuaderno == 0)         //Verifica que sea la primera vez que se escribe sobre este cuaderno
                {
                    escritor = File.AppendText(nombreUsuario + ".txt");
                    escritor.WriteLine(PaginaRichTextBox.Text);
                    escritor.Close();
                    this.Hide();
                }
                else        //En otro caso sobreescribe los cambios
                {
                    SobreescribirArchivo(idCuaderno - 1);
                }
            }
            else if (cerrar == DialogResult.No)     //En caso que desee salir sin guardar o haya guardado antes de presionar el boton cerrar
            {
                this.Hide();
            }
            MenuForm estanteria1 = new MenuForm(nombreUsuario);
            estanteria1.Show();
        }
        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)       //Permite eliminar la ultima accion realizada
        {
            PaginaRichTextBox.Undo();
        }
        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)        //Si borró algo, permite recuperarlo
        {
            PaginaRichTextBox.Redo();
        }
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)      //Permite copiar texto seleccionado
        {
            PaginaRichTextBox.Copy();
        }
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)       //Permite pegar texto copiado
        {
            PaginaRichTextBox.Paste();
        }
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)      //Copia y elimina texto seleccionado
        {
            PaginaRichTextBox.Cut();
        }
        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)     //Selecciona todo el texto escrito
        {
            PaginaRichTextBox.SelectAll();
        }
        private void eliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)        //Elimina todo el texto seleccionado
        {
            PaginaRichTextBox.Clear();
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)       //Permite modificar el color del texto en las notas
        {
            var c1 = colorDialog1.ShowDialog();     //Abre un dialogo de color
            if (c1 == DialogResult.OK)      //Recibe una respuesta
            {
                PaginaRichTextBox.ForeColor = colorDialog1.Color;       //Realiza los cambios en las notas
            }
        }
        private void EditorDeNotas_Load(object sender, EventArgs e)
        {
            LeerArchivo();
            if(idCuaderno != 0)     //Es una validacion
            {
                CargarArchivo(idCuaderno - 1);     //Carga el texto del cuaderno seleccionado
            }
        }
        public void CargarArchivo(int numeroCuaderno)       //Carga el texto del cuaderno al que se ingreso
        {
            PaginaRichTextBox.Text = campos[numeroCuaderno * 4 + 5].Trim().ToString();
        }
        public void LeerArchivo()       //Permite leer todo el archivo .txt del usuario y otorga datos a las variables
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
        public void SobreescribirArchivo(int numeroCuaderno)        //Se reescribe el archivo para almacenar su contenido
        {
            LeerArchivo();
            File.Delete(nombreUsuario + ".txt");        //Elimina el contenido del archivo
            StreamWriter escritor = new StreamWriter(nombreUsuario + ".txt");       //Permite escribir en el .txt
            campos[numeroCuaderno * 4 + 5] = PaginaRichTextBox.Text;        //Escribe las notas del cuaderno en el .txt
            for (int i = 0; i < campos.Length; i++)     //Sobreescribe todo el archivo .txt
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
            escritor.Close();       //Cierra el escritor de archivos
        }
    }
}
