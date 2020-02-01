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
using Notebook.UNA.MySql;

namespace Notebook
{
    public partial class CrearForm : Form
    {
        int idUsuario = 0;      //Almacena el id de usuario
        string tituloCuaderno = "";
        string categoriaCuaderno = "";
        string colorCuaderno = "";
        string nombreUsuario = "";
        int idCuaderno = 0;
        List<string> historial;
        public CrearForm(int idUsuario, string nombreUsuario, List<string> historial)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.historial = historial;
        }

        public CrearForm(int idUsuario, string nombreUsuario, List<string> historial, bool modificar, int idCuaderno , string tituloCuaderno)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.historial = historial;
            this.idCuaderno = idCuaderno;
            this.tituloCuaderno = tituloCuaderno;
            GuardarButton.Text = "Modificar";
        }

        private bool InformacionEsValida()      //Verifica que todos los textbox contengan informacion
        {
            LimpiarErrorProvider();
            bool esValida = true;
            if (NombreTextBox.Text == "" || NombreTextBox.Text == "Nombre")
            {
                esValida = false;
                GuardadoErrorProvider.SetError(NombreTextBox, "Debe especificar un nombre para el cuaderno.");
            }
            if (CategoriaTextBox.Text == "" || CategoriaTextBox.Text == "Categoría")
            {
                esValida = false;
                GuardadoErrorProvider.SetError(CategoriaTextBox, "Debe especificar una categoria para el cuaderno.");
            }
            return esValida;
        }
        private void GuardarButton_Click(object sender, EventArgs e)        //Crea un cuadernos con los datos agregados por el usuario
        {
            MySqlAccess acceso = new MySqlAccess();
            acceso.OpenConnection();
            if (GuardarButton.Text == "Modificar") 
            {
                acceso.EjectSQL(string.Format("update Cuadernos set titulo = '{0}', categoria = '{1}', color = '{2}'  where id_cuaderno = '{3}'", NombreTextBox.Text, CategoriaTextBox.Text, IdentificarColor(), idCuaderno));
                acceso.CloseConnection();
                MessageBox.Show("Se ha modificado el cuaderno con éxito.");
                historial.Add("Se modifico el cuaderno " + tituloCuaderno);
                MenuFormulario form = new MenuFormulario(idUsuario, nombreUsuario, historial, false);
                this.Close();
                form.Show();
            }
            tituloCuaderno = NombreTextBox.Text;
            categoriaCuaderno = CategoriaTextBox.Text;
            colorCuaderno = IdentificarColor();
            if (NombreTextBox.Text == "Nombre" && CategoriaTextBox.Text == "Categoría")
            {
                InformacionEsValida();
            }
            else if (InformacionEsValida())
            {
                
                acceso.EjectSQL(string.Format("insert into Cuadernos(usuario,titulo,categoria,color) values('{0}','{1}','{2}','{3}')",idUsuario, tituloCuaderno, categoriaCuaderno,colorCuaderno));
                acceso.CloseConnection();
                MessageBox.Show("Se ha creado el cuaderno con éxito.");
                historial.Add("Se creó el cuaderno " + tituloCuaderno);
                MenuFormulario form = new MenuFormulario(idUsuario,nombreUsuario,historial,false);
                this.Close();
                form.Show();
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
            MenuFormulario menu = new MenuFormulario(idUsuario,nombreUsuario,historial,false);
            menu.Show();
        }

        private void LimpiarErrorProvider()     //Limpia el errorProvider de los textBox
        {
            GuardadoErrorProvider.SetError(NombreTextBox, "");
            GuardadoErrorProvider.SetError(CategoriaTextBox, "");
        }

        private void NombreTextBox_Enter(object sender, EventArgs e)
        {
            if (NombreTextBox.Text == "Nombre")
            {
                NombreTextBox.Text = "";
                NombreTextBox.ForeColor = Color.LightGray;
            }
        }

        private void NombreTextBox_Leave(object sender, EventArgs e)
        {
            if(NombreTextBox.Text == "")
            {
                NombreTextBox.Text = "Nombre";
                NombreTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void CategoriaTextBox_Enter(object sender, EventArgs e)
        {
            if (CategoriaTextBox.Text == "Categoría")
            {
                CategoriaTextBox.Text = "";
                CategoriaTextBox.ForeColor = Color.LightGray;
            }
        }

        private void CategoriaTextBox_Leave(object sender, EventArgs e)
        {
            if (CategoriaTextBox.Text == "")
            {
                CategoriaTextBox.Text = "Categoría";
                CategoriaTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void CerrarPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("¿Seguro que desea cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MinimizarPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Modificar()
        {
            
        }
    }
}
