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
    public partial class CrearForm : Form
    {
        StreamWriter escritor;      //Permite escribir en los .txt
        StreamReader lector;        //Permite leer los .txt
        string cadena;      //Se usa para almacenar el contenido del .txt
        string nombreUsuario = "";      //Almacena el nombre de usuario
        string[] campos = new string[47];        //Mediante el caracter " ° " separa el contenido de cadena
        char[] separador = { '°' };     //Almacena el caracter usado como separador
        public CrearForm(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
        }
        public void SobreescribirArchivo()      //Se reescribe el archivo para almacenar su contenido
        {
            LeerArchivo();
            File.Delete(nombreUsuario + ".txt");        //Elimina el contenido del archivo
            StreamWriter escritor = new StreamWriter(nombreUsuario + ".txt");       //Permite escribir en el .txt
            int idCuaderno = Convert.ToInt32(campos[1]);       //Recibe la cantidad de cuadernos creados
            idCuaderno++;      //Se aumenta cantidad de cuadernos creados
            campos[1] = Convert.ToString(idCuaderno);      //Actualiza la cantidad de cuadernos creados
            for (int i = 0; i < campos.Length; i++)     //Reescribe todo el contenido del .txt
            {
                campos[i] = campos[i] + "°";
                escritor.WriteLine(campos[i]);
            }
            escritor.Close();       //Cierra el escritor de archivos 
        }
        public void LeerArchivo()       //Permi leer todo el archivo .txt del usuario y otorga datos a las variables
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
        private void GuardarButton_Click(object sender, EventArgs e)        //Crea un cuadernos con los datos agregados por el usuario
        {
            if (InformacionEsValida())      //Verifica que todos los datos solicitados hayan sido ingresados
            {
                LeerArchivo();
                SobreescribirArchivo();     //Actualiza el contador de cuadernos creados
                escritor = File.AppendText(nombreUsuario + ".txt");
                escritor.Write(NombreTextBox.Text + "°");       //Agrega el nombre de cuaderno creado
                escritor.Write(CategoriaTextBox.Text + "°");        //Agrega la categoria al cuaderno creado
                escritor.Write(IdentificarColor() + "°");       //Agrega un color al cuaderno creado
                escritor.Close();       //Cierra el escritor de archivos
                this.Hide();
                EditorDeNotas cuaderno = new EditorDeNotas(nombreUsuario);      //Abre el formulario de notas
                cuaderno.Show();
            }
        }
        public string IdentificarColor()        //Permite la seleccion de colores para los cuadernos que se van a crear
        {                                       //verificando que RadioButton fue seleccionado
            if (VerdeRadioButton.Checked == true)
            {
                return "Verde";
            }
            else if (AzulRadioButton.Checked == true)
            {
                return "Azul";
            }
            else if (AmarilloRadioButton.Checked == true)
            {
                return "Amarillo";
            }
            else if (CafeRadioButton.Checked == true)
            {
                return "Cafe";
            }
            else 
            {
                return "Rojo";
            }
        }
        private void CancelarButton_Click(object sender, EventArgs e)      //Cancela la creacion de cuadernos
        {
            this.Hide();
            MenuForm menu = new MenuForm(nombreUsuario);
            menu.Show();
        }
        private void GuardadoForm_Load(object sender, EventArgs e)
        {
            LeerArchivo();
            GuardadoToolTip.SetToolTip(NombreTextBox, "Ingresar un nombre para el cuaderno");   //Otorga instrucciones para el usuario
            GuardadoToolTip.SetToolTip(CategoriaTextBox, "Ingresar una categoria para el cuaderno");    //Otorga instrucciones para el usuario
        }
        private bool InformacionEsValida()      //Verifica que todos los textbox contengan informacion
        {
            LimpiarErrorProvider();
            bool esValida = true;
            if (NombreTextBox.Text == "")
            {
                esValida = false;
                GuardadoErrorProvider.SetError(NombreTextBox, "Debe especificar un nombre para el cuaderno");
            }
            if (CategoriaTextBox.Text == "")
            {
                esValida = false;
                GuardadoErrorProvider.SetError(CategoriaTextBox, "Debe especificar una categoria para el cuaderno");
            }
            return esValida;
        }
        private void LimpiarErrorProvider()     //Limpia el errorProvider de los textBox
        {
            GuardadoErrorProvider.SetError(NombreTextBox, "");
            GuardadoErrorProvider.SetError(CategoriaTextBox, "");
        }
    }
}
