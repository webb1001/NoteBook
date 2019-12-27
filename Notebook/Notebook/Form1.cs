using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
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
            InformacionEsValida();
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
    }
}
