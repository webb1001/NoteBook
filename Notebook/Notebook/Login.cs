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

namespace Notebook
{
    public partial class LoginForm : Form
    {
        ListaUsuario listaCuentas = new ListaUsuario();
        Usuario persona1 = new Usuario("Alejandro", "primo861", "88213061");        //Se inicializan los usuarios ya que no ha una base de datos
        Usuario persona2 = new Usuario("Christopher", "webb", "86814065");
        Usuario persona3 = new Usuario("Ruben", "rmoravargas", "profe");
        public LoginForm()
        {
            InitializeComponent();      //Inicia graficamente los componentes del form
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            listaCuentas.Agregar(persona1);     //Se agregan los usuarios a la lista de usuarios
            listaCuentas.Agregar(persona2);
            listaCuentas.Agregar(persona3);
            LoginToolTip.SetToolTip(UsuarioTextBox, "Ingresar el nombre de usuario");       //Se inicializan ambos toolTips para dar informacion al usuario
            LoginToolTip.SetToolTip(ContraseñaTextBox, "Ingresar una contraseña de minimo 5 caracteres");
        }
        private bool InformacionEsValida()      //Verifica que todos los textbox contengan informacion 
        {
            LimpiarErrorProvider();     //Limpia los errorProvider
            bool esValida = true;       //Verifica errores
            if (UsuarioTextBox.Text == "")
            {
                esValida = false;
                LoginErrorProvider.SetError(UsuarioTextBox, "Debe especificar su nombre de usuario");
            }
            if (ContraseñaTextBox.Text == "")
            {
                esValida = false;
                LoginErrorProvider.SetError(ContraseñaTextBox, "Debe escribir su contraseña");
            }
            if (ContraseñaTextBox.Text.Length < 5)
            {
                esValida = false;
                LoginErrorProvider.SetError(ContraseñaTextBox, "Debe escribir una contraseña de minimo 5 caracteres");
            }
            return esValida;
        }
        private void LimpiarErrorProvider()     //Limpia el errorProvider de los textBox
        {
            LoginErrorProvider.SetError(UsuarioTextBox, "");
            LoginErrorProvider.SetError(ContraseñaTextBox, "");
        }
        private void IngresarButton_Click(object sender, EventArgs e)       //Si la informacion es valida permite el acceso a la aplicacion
        {
            MySqlAccess acceso = new MySqlAccess();
            if (InformacionEsValida())
            {
                //if (listaCuentas.Verificar(UsuarioTextBox.Text, ContraseñaTextBox.Text))
                //{
                //    MenuForm estanteria = new MenuForm(UsuarioTextBox.Text);
                //    this.Hide();
                //    estanteria.Show();
                //}
                if (acceso.VerificarLogin(UsuarioTextBox.Text, ContraseñaTextBox.Text) == true)
                {
                   MenuForm estanteria = new MenuForm(UsuarioTextBox.Text);
                   this.Hide();
                   estanteria.Show();
                }
                else
                {
                    MessageBox.Show("El usuario y la contraseña no coinciden...");
                }
            }

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
                if (InformacionEsValida() == true)
                {
                    if (listaCuentas.Verificar(UsuarioTextBox.Text, ContraseñaTextBox.Text) == true)
                    {
                        MenuForm estanteria = new MenuForm(UsuarioTextBox.Text);        //Se abre el menu y se recibe el nombre del usuario que accedió
                        this.Hide();
                        estanteria.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario y la contraseña no coinciden...");
                    }
                }
            }
        }
        private void SalirButton_Click(object sender, EventArgs e)      //Cierra la aplicacion
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroForm registro = new RegistroForm();
            this.Hide();
            registro.Show();
        }

        private void ContraseñaTextBox_Enter(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.Text == "CONTRASEÑA")
            {
                ContraseñaTextBox.Text = "";
                ContraseñaTextBox.ForeColor = Color.LightGray;
                ContraseñaTextBox.UseSystemPasswordChar = true;
            }
        }

        private void ContraseñaTextBox_Leave(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.Text == "")
            {
                ContraseñaTextBox.Text = "CONTRASEÑA";
                ContraseñaTextBox.ForeColor = Color.DarkGray;
                ContraseñaTextBox.UseSystemPasswordChar = false;
            }
        }

        private void UsuarioTextBox_Enter(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == "USUARIO")
            {
                UsuarioTextBox.Text = "";
                UsuarioTextBox.ForeColor = Color.LightGray;
            }
        }

        private void UsuarioTextBox_Leave(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == "")
            {
                UsuarioTextBox.Text = "USUARIO";
                UsuarioTextBox.ForeColor = Color.DarkGray;
            }
        }
    }
} 