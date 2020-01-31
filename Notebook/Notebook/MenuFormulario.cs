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
using Notebook.UNA.Nota;
using MySql.Data.MySqlClient;

namespace Notebook
{
    public partial class MenuFormulario : Form
    {
        ListaCuaderno listaCuaderno = new ListaCuaderno();
        ListaNotas listaNotas = new ListaNotas();
        int idUsuario = 0;
        string nombreUsuario = "";
        Cuaderno cuaderno = new Cuaderno();
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
            this.Size = new Size(sw, sh);
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
            if (AgregarButton.Text == "Agregar cuaderno")
            {
                CrearForm guardado = new CrearForm(idUsuario, nombreUsuario);        //Genera el formulario de creacion de cuadernos 
                guardado.Show();        //Muestra el formularios de creacion de cuadernos
                this.Hide();
            }
            else if (AgregarButton.Text == "Agregar nota")
            {
                CreacionNotas creacion = new CreacionNotas(idUsuario, nombreUsuario, Convert.ToInt32(AgregarButton.Tag));
                creacion.Show();
                this.Hide();
            }
        }

        private void MenuFormulario_Load(object sender, EventArgs e)
        {
            UsuarioLabel.Text = nombreUsuario;
            AlgoCuadernos(idUsuario);
            for (int i = 0; i < listaCuaderno.GetCountLista(); i++)
            {
                DibujarCuadernos(listaCuaderno.ConsultaCuaderno(i), i);
            }

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
        public void DibujarCuadernos(Cuaderno cuaderno, int conteo)      //Metodo que dibuja los cuadernos que posee el usuario 
        {
            Image cuadernoImagen;
            int x = 0;
            int y = 0  + 46 * conteo;
            Button portada = new Button();
            cuadernoImagen = ColorCuaderno(cuaderno);
            portada.AutoSize = false;
            portada.Name = "CuadernoButton" + conteo.ToString();
            portada.Text = cuaderno.titulo;
            portada.Width = 183;
            portada.Height = 46;
            portada.Left = x;
            portada.Top = y;
            portada.Image = cuadernoImagen;
            portada.Tag = cuaderno.idCuaderno;
            portada.FlatStyle = FlatStyle.Flat;
            portada.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            portada.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            portada.Click += new EventHandler(handlerComun_Click);
            InferiozIzquierdoPanel.Controls.Add(portada);
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
        public Image ColorCuaderno(Cuaderno cuaderno)       //Especifica la caracteristica color de los cuadernos
        {
            Image imagen;       //Genera un objeto de tipo imagen
            if (cuaderno.color == "Rojo")
            {
                imagen = Image.FromFile("CuadernoRojoMenu.jpg");     //Si su caracteristica color coincide con "Rojo"
            }
            else if (cuaderno.color == "Azul")
            {
                imagen = Image.FromFile("CuadernoAzulMenu.jpg");     //Si su caracteristica color coincide con "Azul"
            }
            else if (cuaderno.color == "Amarillo")
            {
                imagen = Image.FromFile("CuadernoAmarilloMenu.jpg");        //Si su caracteristica color coincide con "Amarillo"
            }
            else if (cuaderno.color == "Cafe")
            {
                imagen = Image.FromFile("CudernoCafeMenu.jpg");     //Si su caracteristica color coincide con "Cafe"
            }
            else
            {
                imagen = Image.FromFile("CuadernoVerdeMenu.jpg");     //Si su caracteristica color coincide con "Verde"
            }
            return imagen;      //Se retorna la imagen con el color adquirido
        }
        private void handlerComun_Click(object sender, EventArgs e)     //Metodo que permite usar el evento click en todos los cuadernos creados
        {
            CentroPanel.Controls.Clear();
            listaNotas.DeleteLista();
            AgregarButton.Text = "Agregar nota";
            EliminarButton.Text = "Eliminar nota";
            ModificarButton.Text = "Modificar nota";
            AgregarButton.Tag = ((Button)sender).Tag;
            AlgoNotas(Convert.ToInt32(AgregarButton.Tag.ToString()));
            for (int i = 0; i < listaNotas.GetCountNota(); i++)
            {
                DibujarNotas(listaNotas.ConsultaNotas(i), i);
            }
        }
        public void CargarNotas(int idNota, int idCuaderno)
        {
            string titulo = "";
            string categoria = "";
            string texto = "";
            string fechaCreacion = "";
            string fechaModificacion = "";
            MySqlAccess acceso = new MySqlAccess();
            MySqlCommand command = new MySqlCommand(string.Format("SELECT titulo, categoria, fecha_creacion, fecha_modificacion FROM Notas where id_nota = '{0}'", idNota));
            var connection = acceso.GetConnection();
            connection.Open();
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                titulo = reader.GetString(0);
                categoria = reader.GetString(1);
                fechaCreacion = reader.GetString(2);
                fechaModificacion = reader.GetString(3);
            }
            Nota nota = new Nota(idNota, idCuaderno, titulo, categoria, texto, fechaCreacion, fechaModificacion);
            listaNotas.Agregar(nota);
        }

        public void AlgoNotas(int idCuaderno)
        {
            MySqlAccess acceso = new MySqlAccess();
            MySqlCommand command = new MySqlCommand(string.Format("SELECT id_nota FROM Notas where cuaderno = '{0}'", idCuaderno));
            var connection = acceso.GetConnection();
            connection.Open();
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CargarNotas(reader.GetInt32(0), idCuaderno);
            }
        }
        public void DibujarNotas(Nota nota, int conteo)      //Metodo que dibuja los cuadernos que posee el usuario 
        {
            Image notaImagen;
            int x = 0;
            int y = 0 + 100 * conteo;
            Button portada = new Button();
            notaImagen = Image.FromFile("NotasBoton.jpg");
            portada.AutoSize = false;
            portada.Name = "CuadernoButton" + conteo.ToString();
            portada.ForeColor = Color.White;
            portada.Text = nota.titulo;
            portada.Image = notaImagen;
            portada.Tag = cuaderno.idCuaderno;
            portada.Width = 300;
            portada.Height = 85;
            portada.Left = x;
            portada.Top = y;
            portada.FlatStyle = FlatStyle.Flat;
            portada.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            portada.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            portada.Click += new EventHandler(handlerNotas_Click);
            CentroPanel.Controls.Add(portada);
        }
        private void handlerNotas_Click(object sender, EventArgs e)     //Metodo que permite usar el evento click en todos los cuadernos creados
        {
            AbrirFormulario<EditorDeNotas>();
        }
        private void AbrirFormulario<TextoForm>() where TextoForm : Form, new()
        {
            Form editor;
            editor = DerechaPanel.Controls.OfType<TextoForm>().FirstOrDefault(); //Busca en la colección el formulario
            if(editor == null)
            {
                editor = new TextoForm();
                editor.TopLevel = false;
                //editor.FormBorderStyle = FormBorderStyle.None;
                editor.Dock = DockStyle.Fill;
                DerechaPanel.Controls.Add(editor);
                DerechaPanel.Tag = editor;
                editor.Show();
                editor.BringToFront();
            }
            else
            {
                editor.BringToFront();
            }
        }
    }
}
