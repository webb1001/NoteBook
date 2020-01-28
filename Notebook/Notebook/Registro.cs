using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Notebook.UNA.MySql;

namespace Notebook
{
    public partial class RegistroForm : Form
    {
        string nombreCompleto;
        string nombreUsuario;
        string contraseña;
        public RegistroForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void RegistroForm_Load(object sender, EventArgs e)
        {
            RegistroToolTip.SetToolTip(NombreTextBox, "Ingrese su nombre.");       
            RegistroToolTip.SetToolTip(PrimerApellidoTextBox, "Ingrese su primer apellido.");
            RegistroToolTip.SetToolTip(SegundoApellidoTextBox, "Ingrese su segundo apellido.");       
            RegistroToolTip.SetToolTip(UsuarioTextBox, "Ingrese su nombre de usuario.");
            RegistroToolTip.SetToolTip(ContraseñaTextBox, "Ingrese su contraseña (Minimo 5 caracteres, maximo )");       
            RegistroToolTip.SetToolTip(ConfirmarTextBox, "Confirme su contraseña.");
        }
        private void NombreTextBox_Enter(object sender, EventArgs e)
        {
            if(NombreTextBox.Text == "NOMBRE" )
            {
                NombreTextBox.Text = "";
                NombreTextBox.ForeColor = Color.LightGray;
            }
        }
        private void NombreTextBox_Leave(object sender, EventArgs e)
        {
            if (NombreTextBox.Text == "")
            {
                NombreTextBox.Text = "NOMBRE";
                NombreTextBox.ForeColor = Color.DimGray;
            }
        }
        private void PrimerApellidoTextBox_Enter(object sender, EventArgs e)
        {
            if (PrimerApellidoTextBox.Text == "PRIMER APELLIDO")
            {
                PrimerApellidoTextBox.Text = "";
                PrimerApellidoTextBox.ForeColor = Color.LightGray;
            }
        }
        private void PrimerApellidoTextBox_Leave(object sender, EventArgs e)
        {
            if (PrimerApellidoTextBox.Text == "")
            {
                PrimerApellidoTextBox.Text = "PRIMER APELLIDO";
                PrimerApellidoTextBox.ForeColor = Color.DimGray;
            }
        }
        private void SegundoApellidoTextBox_Enter(object sender, EventArgs e)
        {
            if (SegundoApellidoTextBox.Text == "SEGUNDO APELLIDO")
            {
                SegundoApellidoTextBox.Text = "";
                SegundoApellidoTextBox.ForeColor = Color.LightGray;
            }
        }
        private void SegundoApellidoTextBox_Leave(object sender, EventArgs e)
        {
            if (SegundoApellidoTextBox.Text == "")
            {
                SegundoApellidoTextBox.Text = "SEGUNDO APELLIDO";
                SegundoApellidoTextBox.ForeColor = Color.DimGray;
            }
        }
        private void UsuarioTextBox_Enter(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == "NOMBRE USUARIO")
            {
                UsuarioTextBox.Text = "";
                UsuarioTextBox.ForeColor = Color.LightGray;
            }
        }
        private void UsuarioTextBox_Leave(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == "")
            {
                UsuarioTextBox.Text = "NOMBRE USUARIO";
                UsuarioTextBox.ForeColor = Color.DimGray;
            }
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
                ContraseñaTextBox.ForeColor = Color.DimGray;
                ContraseñaTextBox.UseSystemPasswordChar = false;
            }
        }
        private void ConfirmarTextBox_Enter(object sender, EventArgs e)
        {
            if (ConfirmarTextBox.Text == "CONFIRMAR CONTRASEÑA")
            {
                ConfirmarTextBox.Text = "";
                ConfirmarTextBox.ForeColor = Color.LightGray;
                ConfirmarTextBox.UseSystemPasswordChar = true;
            }
        }
        private void ConfirmarTextBox_Leave(object sender, EventArgs e)
        {
            if (ConfirmarTextBox.Text == "")
            {
                ConfirmarTextBox.Text = "CONFIRMAR CONTRASEÑA";
                ConfirmarTextBox.ForeColor = Color.DimGray;
                ConfirmarTextBox.UseSystemPasswordChar = false;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void LimpiarErrorProvider()
        {
            RegistroErrorProvider.SetError(NombreTextBox, "");
            RegistroErrorProvider.SetError(PrimerApellidoTextBox, "");
            RegistroErrorProvider.SetError(SegundoApellidoTextBox, "");
            RegistroErrorProvider.SetError(UsuarioTextBox, "");
            RegistroErrorProvider.SetError(ContraseñaTextBox, "");
            RegistroErrorProvider.SetError(ConfirmarTextBox, "");
        }
        private bool InformacionEsValida()      //Verifica que todos los textbox contengan informacion 
        {
            LimpiarErrorProvider();     //Limpia los errorProvider
            bool esValida = true;       //Verifica errores
            if (NombreTextBox.Text == "NOMBRE")
            {
                esValida = false;
                RegistroErrorProvider.SetError(NombreTextBox, "Debe especificar su nombre.");
            }
            if (PrimerApellidoTextBox.Text == "PRIMER APELLIDO")
            {
                esValida = false;
                RegistroErrorProvider.SetError(PrimerApellidoTextBox, "Debe especificar su primer apellido.");
            }
            if (SegundoApellidoTextBox.Text == "SEGUNDO APELLIDO")
            {
                esValida = false;
                RegistroErrorProvider.SetError(SegundoApellidoTextBox, "Debe especificar su segundo apellido.");
            }
            if (UsuarioTextBox.Text == "NOMBRE USUARIO")
            {
                esValida = false;
                RegistroErrorProvider.SetError(UsuarioTextBox, "Debe especificar su nombre de usuario.");
            }
            if (ContraseñaTextBox.Text.Length < 5 || ContraseñaTextBox.Text == "CONTRASEÑA")
            {
                esValida = false;
                RegistroErrorProvider.SetError(ContraseñaTextBox, "Debe escribir una contraseña de minimo 5 caracteres.");
            }
            if (ConfirmarTextBox.Text.Length < 5 || ConfirmarTextBox.Text == "CONFIRMAR CONTRASEÑA")
            {
                esValida = false;
                RegistroErrorProvider.SetError(ConfirmarTextBox, "Confirme su contraseña.");
            }
            return esValida;
        }
        private void AceptarButton_Click(object sender, EventArgs e)
        {
            nombreCompleto = NombreTextBox.Text + " " + PrimerApellidoTextBox.Text + " " + SegundoApellidoTextBox.Text;
            nombreUsuario = UsuarioTextBox.Text;
            contraseña = ContraseñaTextBox.Text;
            if ( ContraseñaTextBox.Text != "CONTRASEÑA" && ConfirmarTextBox.Text != "CONFIRMAR CONTRASEÑA" && (ContraseñaTextBox.Text != ConfirmarTextBox.Text))
            {
                InformacionEsValida();
                MessageBox.Show("La contraseña no coincide.");
            }
            else if (InformacionEsValida())
            {
                MySqlAccess acceso = new MySqlAccess();
                acceso.ConnectionString = "server=localhost;database=NotebookDb;uid=root;pwd=mfml1603";
                acceso.OpenConnection();
                acceso.EjectSQL(string.Format("insert into Usuarios(nombre_completo,nombre_usuario,contraseña) values('{0}','{1}','{2}')", nombreCompleto, nombreUsuario, contraseña));
                acceso.CloseConnection();
                MessageBox.Show("Se ha registrado con exito, felicidades.");
                LoginForm form = new LoginForm();
                this.Close();
                form.Show();
            }
        }

        private void Cancelarutton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Close();
            form.Show();
        }
    }
}
