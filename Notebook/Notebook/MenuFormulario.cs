using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Notebook.UNA.MySql;
using Notebook.UNA.Cuaderno;
using MySql.Data.MySqlClient;

namespace Notebook
{
    public partial class MenuFormulario : Form
    {
        ListaCuaderno listaCuaderno = new ListaCuaderno();
        int idUsuario = 0;
        string nombreUsuario = "";
        public MenuFormulario(int idUsuario, string nombreUsuario)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            InitializeComponent();
        }
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.FondoPanel.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(100, 65, 164));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
          //  base.OnPaint(e);
          //  ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void CerrarPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("¿Seguro que desea cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)
            {
                Application.Exit();
            }
                
            //Hacer message box de confirmar...
        }

        //Capturar posición y tamaño antes de maximizar para restaurar
        int lx;
        int ly;
        int sw;
        int sh;
        private void MaximizarPictureBox_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            MaximizarPictureBox.Visible = false;
            RestaurarPictureBox.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void RestaurarPictureBox_Click(object sender, EventArgs e)
        {
            MaximizarPictureBox.Visible = true;
            RestaurarPictureBox.Visible = false;
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx, ly);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void BarraSuperiorPanel_MouseMove(object sender, MouseEventArgs e)
        {
             ReleaseCapture();
             SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MinimizarPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            CrearForm guardado = new CrearForm(idUsuario,nombreUsuario);        //Genera el formulario de creacion de cuadernos 
            guardado.Show();        //Muestra el formularios de creacion de cuadernos
            this.Hide();
        }

        private void MenuFormulario_Load(object sender, EventArgs e)
        {
            UsuarioLabel.Text = nombreUsuario;

        }

        private void CerrarSesiónButton_Click(object sender, EventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)
            {
                this.Close();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
        public void DibujarCuadernos(string tituloCuaderno)      //Metodo que dibuja los cuadernos que posee el usuario 
        {
            // Image cuadernoImagen;
            int x = 0;
            int y = 120;
            int conteo = 1;
            Button cuaderno = new Button();
            //   cuadernoImagen = ColorCuaderno(i);
            cuaderno.AutoSize = false;
            cuaderno.Name = "CuadernoButton" + conteo.ToString();
            cuaderno.Text = tituloCuaderno;
            cuaderno.Width = 200;
            cuaderno.Height = 46;
            cuaderno.Left = x;
            cuaderno.Top = y;
            // cuaderno.Image = cuadernoImagen;
            cuaderno.BackColor = Color.Transparent;
           // cuaderno.Click += new EventHandler(handlerComun_Click);
            IzquierdaPanel.Controls.Add(cuaderno);
            y += 46;
            conteo++;
        }
        public void CargarCuadernos(int idCuaderno)
        {
            string titulo = "";
            string categoria = "";
            string color = "";
            MySqlAccess acceso = new MySqlAccess();
            MySqlCommand command = new MySqlCommand(string.Format("SELECT titulo, categoria, color FROM Cuadernos where id_cuaderno = '{0}'", idCuaderno));
            var connection = acceso.GetConnection();
            connection.Open();
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                titulo = reader.GetString(0);
                categoria = reader.GetString(1);
                color = reader.GetString(2);
            }
            Cuaderno cuaderno = new Cuaderno(idCuaderno, idUsuario, titulo, categoria, color);
            listaCuaderno.Agregar(cuaderno);
        }

        public void AlgoCuadernos(int idUsuario)
        {
            MySqlAccess acceso = new MySqlAccess();
            MySqlCommand command = new MySqlCommand(string.Format("SELECT id_cuaderno FROM Cuadernos where usuario = '{0}'", idUsuario));
            var connection = acceso.GetConnection();
            connection.Open();
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CargarCuadernos(reader.GetInt32(0));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlgoCuadernos(idUsuario);
            MessageBox.Show( listaCuaderno.Prueba());
        }
    }
}
