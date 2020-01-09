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

namespace Notebook
{
    public partial class LoginForm : Form
    {
        ListaUsuario listaCuentas = new ListaUsuario();
        Usuario persona1 = new Usuario("Alejandro", "primo861", "88213061");
        Usuario persona2 = new Usuario("Christopher", "webb", "86814065");
        Usuario persona3 = new Usuario("SinNombre", "profe", "twice");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            listaCuentas.Agregar(persona1);
            listaCuentas.Agregar(persona2);
            listaCuentas.Agregar(persona3);
            UsuarioLabel.BackColor = Color.Transparent;
            ContraseñaLabel.BackColor = Color.Transparent;
            LoginToolTip.SetToolTip(UsuarioTextBox, "Ingresar el nombre de usuario");
            LoginToolTip.SetToolTip(ContraseñaTextBox, "Ingresar una contraseña de minimo 5 caracteres");

        }
        private bool InformacionEsValida()
        {
            LimpiarErrorProvider();
            bool esValida = true;
            if(UsuarioTextBox.Text == "")
            {
                esValida = false;
                LoginErrorProvider.SetError(UsuarioTextBox, "Debe especificar su nombre de usuario");
            }
            if(ContraseñaTextBox.Text == "")
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
        private void LimpiarErrorProvider()
        {
            LoginErrorProvider.SetError(UsuarioTextBox, "");
            LoginErrorProvider.SetError(ContraseñaTextBox, "");
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            if(InformacionEsValida() == true) 
            {
                if(listaCuentas.Verificar(UsuarioTextBox.Text, ContraseñaTextBox.Text) == true )
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

        private void Button_Click(object sender, EventArgs e)
        {
            if(ContraseñaTextBox.PasswordChar == '*')
            {
                ContraseñaTextBox.PasswordChar = '\0';
            }
            else if(ContraseñaTextBox.PasswordChar == '\0')
            {
                ContraseñaTextBox.PasswordChar = '*';
            }
        }

        private void LoginToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContraseñaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (InformacionEsValida() == true)
                {
                    if (listaCuentas.Verificar(UsuarioTextBox.Text, ContraseñaTextBox.Text) == true)
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
        }
    }
}
