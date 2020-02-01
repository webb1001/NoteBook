using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Notebook.UNA.MySql;
using Notebook.UNA.Encriptar;

namespace Notebook
{
    public partial class RegistroForm : Form
    {
        string nombreCompleto;      //Ingresar datos al DataBase
        string nombreUsuario;       //Ingresar datos al DataBase
        string contraseña;      //Ingresar datos al DataBase
        public RegistroForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]        //Funciones para perminir el movimiento del formulario
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        private void RegistroForm_Load(object sender, EventArgs e)      //Instrucciones ToolTip en los controles
        {
            RegistroToolTip.SetToolTip(NombreTextBox, "Ingrese su nombre.");
            RegistroToolTip.SetToolTip(PrimerApellidoTextBox, "Ingrese su primer apellido.");
            RegistroToolTip.SetToolTip(SegundoApellidoTextBox, "Ingrese su segundo apellido.");
            RegistroToolTip.SetToolTip(UsuarioTextBox, "Ingrese su nombre de usuario.");
            RegistroToolTip.SetToolTip(ContraseñaTextBox, "Ingrese su contraseña (Minimo 5 carácteres)");
            RegistroToolTip.SetToolTip(ConfirmarTextBox, "Confirme su contraseña.");
            RegistroToolTip.SetToolTip(OjoContraseñaButton, "Muestra la contraseña");
            RegistroToolTip.SetToolTip(OjoConfirmarButton, "Muestra la contraseña");
        }
        private void NombreTextBox_Enter(object sender, EventArgs e)    //Al entrar en los textBox Nombre
        {
            if (NombreTextBox.Text == "NOMBRE")
            {
                NombreTextBox.Text = "";
                NombreTextBox.ForeColor = Color.LightGray;      // cambia aun color mas claro
            }
        }
        private void NombreTextBox_Leave(object sender, EventArgs e)        //Al salir del textBox
        {
            if (NombreTextBox.Text == "")
            {
                NombreTextBox.Text = "NOMBRE";
                NombreTextBox.ForeColor = Color.DimGray;        //vuelve al color oscuro
            }
        }
        private void PrimerApellidoTextBox_Enter(object sender, EventArgs e)        //Al entrar en los textBox Primer apellido
        {
            if (PrimerApellidoTextBox.Text == "PRIMER APELLIDO")
            {
                PrimerApellidoTextBox.Text = "";
                PrimerApellidoTextBox.ForeColor = Color.LightGray;
            }
        }
        private void PrimerApellidoTextBox_Leave(object sender, EventArgs e)         //Al salir del textBox
        {
            if (PrimerApellidoTextBox.Text == "")
            {
                PrimerApellidoTextBox.Text = "PRIMER APELLIDO";
                PrimerApellidoTextBox.ForeColor = Color.DimGray;
            }
        }
        private void SegundoApellidoTextBox_Enter(object sender, EventArgs e)       //Al entrar en los textBox Segundo apellido
        {
            if (SegundoApellidoTextBox.Text == "SEGUNDO APELLIDO")
            {
                SegundoApellidoTextBox.Text = "";
                SegundoApellidoTextBox.ForeColor = Color.LightGray;
            }
        }
        private void SegundoApellidoTextBox_Leave(object sender, EventArgs e)        //Al salir del textBox
        {
            if (SegundoApellidoTextBox.Text == "")
            {
                SegundoApellidoTextBox.Text = "SEGUNDO APELLIDO";
                SegundoApellidoTextBox.ForeColor = Color.DimGray;
            }
        }
        private void UsuarioTextBox_Enter(object sender, EventArgs e)       //Al entrar en los textBox Usuario
        {
            if (UsuarioTextBox.Text == "NOMBRE USUARIO")
            {
                UsuarioTextBox.Text = "";
                UsuarioTextBox.ForeColor = Color.LightGray;
            }
        }
        private void UsuarioTextBox_Leave(object sender, EventArgs e)        //Al salir del textBox
        {
            if (UsuarioTextBox.Text == "")
            {
                UsuarioTextBox.Text = "NOMBRE USUARIO";
                UsuarioTextBox.ForeColor = Color.DimGray;
            }
        }
        private void ContraseñaTextBox_Enter(object sender, EventArgs e)        //Al entrar en los textBox Contraseña
        {
            if (ContraseñaTextBox.Text == "CONTRASEÑA")
            {
                ContraseñaTextBox.Text = "";
                ContraseñaTextBox.ForeColor = Color.LightGray;
                ContraseñaTextBox.UseSystemPasswordChar = true;
            }
        }
        private void ContraseñaTextBox_Leave(object sender, EventArgs e)         //Al salir del textBox
        {
            if (ContraseñaTextBox.Text == "")
            {
                ContraseñaTextBox.Text = "CONTRASEÑA";
                ContraseñaTextBox.ForeColor = Color.DimGray;
                ContraseñaTextBox.UseSystemPasswordChar = false;
            }
        }
        private void ConfirmarTextBox_Enter(object sender, EventArgs e)     //Al entrar en los textBox Confirmar
        {
            if (ConfirmarTextBox.Text == "CONFIRMAR CONTRASEÑA")
            {
                ConfirmarTextBox.Text = "";
                ConfirmarTextBox.ForeColor = Color.LightGray;
                ConfirmarTextBox.UseSystemPasswordChar = true;
            }
        }
        private void ConfirmarTextBox_Leave(object sender, EventArgs e)      //Al salir del textBox
        {
            if (ConfirmarTextBox.Text == "")
            {
                ConfirmarTextBox.Text = "CONFIRMAR CONTRASEÑA";
                ConfirmarTextBox.ForeColor = Color.DimGray;
                ConfirmarTextBox.UseSystemPasswordChar = false;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)      //Salir de la aplicacion
        {
            DialogResult cerrar = MessageBox.Show("¿Seguro que desea cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)      //Minimizar el formulario
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)      //Mover el formulario
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)     
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void LimpiarErrorProvider()     //Verificar datos
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
                RegistroErrorProvider.SetError(ContraseñaTextBox, "Debe escribir una contraseña de mínimo 5 caracteres.");
            }
            if (ConfirmarTextBox.Text.Length < 5 || ConfirmarTextBox.Text == "CONFIRMAR CONTRASEÑA")
            {
                esValida = false;
                RegistroErrorProvider.SetError(ConfirmarTextBox, "Confirme su contraseña.");
            }
            return esValida;
        }
        private void AceptarButton_Click(object sender, EventArgs e)        //Agrega al usuario a la base de datos
        {
            Encriptar encriptar = new Encriptar();      //Objeto de la clase Encriptar
            nombreCompleto = NombreTextBox.Text + " " + PrimerApellidoTextBox.Text + " " + SegundoApellidoTextBox.Text;
            nombreUsuario = UsuarioTextBox.Text;
            contraseña = encriptar.Encriptamiento(ContraseñaTextBox.Text);      //Se encripta la contraseña
            if (ContraseñaTextBox.Text != "CONTRASEÑA" && ConfirmarTextBox.Text != "CONFIRMAR CONTRASEÑA" && (ContraseñaTextBox.Text != ConfirmarTextBox.Text))
            {
                InformacionEsValida();
                MessageBox.Show("La contraseña no coincide.");
            }
            else if (InformacionEsValida())
            {
                MySqlAccess acceso = new MySqlAccess();
                acceso.OpenConnection();        //Se abre la conexion
                acceso.EjectSQL(string.Format("insert into Usuarios(nombre_completo,nombre_usuario,contraseña) values('{0}','{1}','{2}')", nombreCompleto, nombreUsuario, contraseña)); //Se agrega un usuario a la base de datos
                acceso.CloseConnection();       //Se cierra la conexion
                MessageBox.Show("Se ha registrado con exito, felicidades.");
                LoginForm form = new LoginForm();
                this.Close();
                form.Show();
            }
        }

        private void Cancelarutton_Click(object sender, EventArgs e)        //Vuelve al LoginForm
        {
            LoginForm form = new LoginForm();
            this.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)      //Revela el contenido de ContraseñaTextBox
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

        private void OjoConfirmarButton_Click(object sender, EventArgs e)       //Revela el contenido de ConfirmarTextBox
        {
            if (ConfirmarTextBox.UseSystemPasswordChar == true)
            {
                ConfirmarTextBox.UseSystemPasswordChar = false;
            }
            else if (ConfirmarTextBox.UseSystemPasswordChar == false && ConfirmarTextBox.Text != "CONFIRMAR CONTRASEÑA")
            {
                ConfirmarTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
