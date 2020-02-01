using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notebook.UNA.MySql;
using Notebook.UNA.Encriptar;

namespace Notebook
{
    public partial class CreacionNotas : Form
    {
        int idNota = 0;     //Almacena el id de la no
        int idUsuario = 0;      //Almacena el ide de usuario
        int idCuaderno = 0;     //Almacena el id del cuaderno al que pertenece la nota
        string nombreUsuario = "";         //Almacena el nombre del usuario logeado
        string tituloNota = "";     //Almacena el titulo de la nota
        string categoriaNota = "";      //Almcena la categoria de la nota
        string fechaCreacion = "";      //Almacena la fecha de creacion de la nota
        string fechaModificacion = "";      //Almacena la fecha de modificacion
        List<string> historial;     //Almacena el historial de actividades
        public CreacionNotas(int idUsuario, string nombreUsuario, int idCuaderno, List<string> historial)   //Constructor para llamara este form en el MenuFormulario 
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.idCuaderno = idCuaderno;
            this.historial = historial;
        }

        public CreacionNotas(int idUsuario, string nombreUsuario, List<string> historial, bool modificar, int idNota, string tituloNota)  //Constructor para cuando se modifican datos 
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.historial = historial;
            this.idNota = idNota;
            this.tituloNota = tituloNota;
            GuardarButton.Text = "Modificar";
        }

        private void button1_Click(object sender, EventArgs e)      //Cierra el formulario
        {
            this.Close();
            MenuFormulario menu = new MenuFormulario(idUsuario, nombreUsuario, historial, false);       //Envia parametros necesarios para abrir el MenuFormulario de la forma correcta
            menu.Show();
        }

        private void TituloTextBox_Enter(object sender, EventArgs e)  //Al entrar en los textBox titulo
        {
            if (TituloTextBox.Text == "TÍTULO")
            {
                TituloTextBox.Text = "";
                TituloTextBox.ForeColor = Color.GhostWhite;
            }
        }

        private void TituloTextBox_Leave(object sender, EventArgs e)    //Al salir del textBox titulo
        {
            if (TituloTextBox.Text == "")
            {
                TituloTextBox.Text = "TÍTULO";
                TituloTextBox.ForeColor = Color.Black;
            }
        }

        private void CategoriaTextBox_Enter(object sender, EventArgs e)  //Al entrar en los textBox categoria
        {
            if (CategoriaTextBox.Text == "CATEGORÍA")
            {
                CategoriaTextBox.Text = "";
                CategoriaTextBox.ForeColor = Color.GhostWhite;
            }
        }

        private void CategoriaTextBox_Leave(object sender, EventArgs e) //Al salir del texBox categoria
        {
            if (CategoriaTextBox.Text == "")
            {
                CategoriaTextBox.Text = "CATEGORÍA";
                CategoriaTextBox.ForeColor = Color.Black;
            }
        }

        private void LimpiarErrorProvider()     //Limpia el errorProvider de los textBox
        {
            NotasErrorProvider.SetError(TituloTextBox, "");
            NotasErrorProvider.SetError(CategoriaTextBox, "");
        }

        private bool InformacionEsValida()      //Verifica que todos los textbox contengan informacion
        {
            LimpiarErrorProvider();
            bool esValida = true;
            if (TituloTextBox.Text == "" || TituloTextBox.Text =="TÍTULO")
            {
                esValida = false;
                NotasErrorProvider.SetError(TituloTextBox, "Debe especificar un nombre para la nota.");
            }
            if (CategoriaTextBox.Text == "" || CategoriaTextBox.Text == "CATEGORÍA")
            {
                esValida = false;
                NotasErrorProvider.SetError(CategoriaTextBox, "Debe especificar una categoría para la nota.");
            }
            return esValida;
        }

        private void GuardarButton_Click(object sender, EventArgs e)    //Función que agrega las notas a la base de datos
        {
            Encriptar encriptar = new Encriptar();      //Objeto de Encriptar
            tituloNota = TituloTextBox.Text;
            categoriaNota = CategoriaTextBox.Text;
            fechaCreacion = DateTime.Now.ToString();
            string texto = "Ingrese el texto";
            MySqlAccess acceso = new MySqlAccess();
            acceso.OpenConnection();                   
            if (GuardarButton.Text == "Modificar")
            {
                acceso.EjectSQL(string.Format("update Notas set titulo = '{0}', categoria = '{1}' where id_nota = '{2}'", TituloTextBox.Text, CategoriaTextBox.Text, idNota));
                acceso.CloseConnection();
                MessageBox.Show("Se ha modificado la nota con éxito.");
                historial.Add("Se modifico la nota " + tituloNota);
                MenuFormulario form = new MenuFormulario(idUsuario, nombreUsuario, historial, false);
                this.Close();
                form.Show();
            }
            else
            {
                if (TituloTextBox.Text == "Nombre" || CategoriaTextBox.Text == "Categoría")
                {
                    InformacionEsValida();
                    MessageBox.Show("Faltan datos.");
                }
                else if (InformacionEsValida())
                {
                    acceso.EjectSQL(string.Format("insert into Notas(cuaderno,titulo,fecha_creacion, fecha_modificacion, categoria, texto) values('{0}','{1}','{2}','{3}','{4}','{5}')", idCuaderno, tituloNota, fechaCreacion, fechaModificacion, categoriaNota, encriptar.Encriptamiento(texto)));
                    acceso.CloseConnection();
                    MessageBox.Show("Se ha creado la nota con éxito.");
                    historial.Add("Se creó la nota " + tituloNota);
                    MenuFormulario form = new MenuFormulario(idUsuario, nombreUsuario, historial, false);
                    this.Close();
                    form.Show();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("¿Seguro que desea cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
