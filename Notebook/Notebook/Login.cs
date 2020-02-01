using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notebook.UNA.Usuario;
using Notebook.UNA.MySql;
using System.Runtime.InteropServices;
using Notebook.UNA.Encriptar;

namespace Notebook
{
    public partial class LoginForm : Form
    {
        int idUsuario = 0;      //Permite conocer el identificador de usuario logeado en el formulario
        public LoginForm()
        {
            InitializeComponent();      //Inicia graficamente los componentes del form
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

            LoginToolTip.SetToolTip(UsuarioTextBox, "Ingresar el nombre de usuario");       //Se inicializan ambos toolTips para dar informacion al usuario
            LoginToolTip.SetToolTip(ContraseñaTextBox, "Ingresar una contraseña de minimo 5 caracteres");
        }
        private bool InformacionEsValida()      //Verifica que todos los textbox contengan informacion 
        {
            LimpiarErrorProvider();     //Limpia los errorProvider
            bool esValida = true;       //Verifica errores
            if (UsuarioTextBox.Text == "" || UsuarioTextBox.Text == "NOMBRE")
            {
                esValida = false;
                LoginErrorProvider.SetError(UsuarioTextBox, "Debe especificar su nombre de usuario");
            }
            if (ContraseñaTextBox.Text == "" || ContraseñaTextBox.Text == "CONTRASEÑA")
            {
                esValida = false;
                LoginErrorProvider.SetError(ContraseñaTextBox, "Debe escribir su contraseña");
            }
            if (ContraseñaTextBox.Text.Length < 5)
            {
                esValida = false;
                LoginErrorProvider.SetError(ContraseñaTextBox, "Debe escribir una contraseña de mínimo 5 carácteres");
            }
            return esValida;
        }
        private void LimpiarErrorProvider()     //Limpia el errorProvider de los textBox
        {
            LoginErrorProvider.SetError(UsuarioTextBox, "");
            LoginErrorProvider.SetError(ContraseñaTextBox, "");
        }

        private void Verificacion()     //Hace la verificacion de login incluyendo la contraseña encriptada
        {
            Encriptar encriptar = new Encriptar();
            MySqlAccess acceso = new MySqlAccess();
            if (InformacionEsValida())
            {
                if (acceso.VerificarLogin(UsuarioTextBox.Text, encriptar.Encriptamiento(ContraseñaTextBox.Text)))  //Recibe la contraseña del textBox y la encripta para compararla con la de base de datos
                {
                    idUsuario = acceso.RetornaUsuario();        //Recibe el idUsuario de la base de datos
                    MenuFormulario menu = new MenuFormulario(idUsuario, UsuarioTextBox.Text);      
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("El usuario y la contraseña no coinciden...");
                }
            }
        }
        private void IngresarButton_Click(object sender, EventArgs e)       //Si la informacion es valida permite el acceso a la aplicacion
        {
            Verificacion();
        }
        private void VisibleButton_Click(object sender, EventArgs e)        //Permite visualizar la contraseña
        {
            if (ContraseñaTextBox.UseSystemPasswordChar == true)
            {
                ContraseñaTextBox.UseSystemPasswordChar = false;
            }
            else if (ContraseñaTextBox.UseSystemPasswordChar == false && ContraseñaTextBox.Text != "CONTRASEÑA")
            {
                ContraseñaTextBox.UseSystemPasswordChar = true;
            }
        }
        private void ContraseñaTextBox_KeyPress(object sender, KeyPressEventArgs e)     //Permite usar la tecla Enter como atajo
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Verificacion();
            }
        }
        private void SalirButton_Click(object sender, EventArgs e)      //Cierra la aplicacion
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)      //Abre el formulario de registro
        {
            RegistroForm registro = new RegistroForm();
            this.Hide();
            registro.Show();
        }

        private void ContraseñaTextBox_Enter(object sender, EventArgs e)        //Vacia el texto de textBox para escribir los datos
        {
            if (ContraseñaTextBox.Text == "CONTRASEÑA")
            {
                ContraseñaTextBox.Text = "";
                ContraseñaTextBox.ForeColor = Color.LightGray;
                ContraseñaTextBox.UseSystemPasswordChar = true;
            }
        }

        private void ContraseñaTextBox_Leave(object sender, EventArgs e)        //LLena nuevamente el textbox con la instruccion
        {
            if (ContraseñaTextBox.Text == "")
            {
                ContraseñaTextBox.Text = "CONTRASEÑA";
                ContraseñaTextBox.ForeColor = Color.DarkGray;
                ContraseñaTextBox.UseSystemPasswordChar = false;
            }
        }

        private void UsuarioTextBox_Enter(object sender, EventArgs e)       //Vacia el texto de textBox para escribir los datos
        {
            if (UsuarioTextBox.Text == "USUARIO")
            {
                UsuarioTextBox.Text = "";
                UsuarioTextBox.ForeColor = Color.LightGray;
            }
        }

        private void UsuarioTextBox_Leave(object sender, EventArgs e)       //LLena nuevamente el textbox con la instruccion
        {
            if (UsuarioTextBox.Text == "")
            {
                UsuarioTextBox.Text = "USUARIO";
                UsuarioTextBox.ForeColor = Color.DarkGray;
            }
        }
    
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]        //Funciones para perminir el movimiento del formulario
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)       ////Funciones para perminir el movimiento del formulario
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)      //Permite cerrar la aplicacion
        {
            DialogResult cerrar = MessageBox.Show("¿Seguro que desea cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
} 