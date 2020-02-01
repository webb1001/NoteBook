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
using Notebook.UNA.Encriptar;

namespace Notebook
{
    public partial class MenuFormulario : Form
    {
        List<String> historial = new List<String>();        //Lista que contiene el historial de acciones
        ListaCuaderno listaCuaderno = new ListaCuaderno();      //Objeto de la lista de cuadernos para editar datos 
        ListaNotas listaNotas = new ListaNotas();       //Objeto de la lista de notas
        int idUsuario = 0;      //Identificador del usuario logeado
        string nombreUsuario = "";      //Nombre del usuario logueado
        Cuaderno cuaderno = new Cuaderno();     //Objeto de tipo cuaderno
        bool iniciarSesion = true;      //Bool que muestra si la sesion esta iniciada
        bool visibleNota = false;       //Es una validacion de notas
        bool eliminarCuaderno = false;      //Permite eliminar cuadernos
        bool eliminarNota = false;      //Permite eliminar notas
        bool modificarNota = false;     //Permite modificar notas
        bool modificarCuaderno = false;     //Permite modificar cuadernos 
        public MenuFormulario(int idUsuario, string nombreUsuario)      //Recibe los parametros de login 
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            InitializeComponent();
        }
        public MenuFormulario(int idUsuario, string nombreUsuario, List<string> historial,bool iniciarSesion)   //Recibe los parametros del formulario Guardado cuadernos 
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.historial = historial;
            InitializeComponent();
            this.iniciarSesion = iniciarSesion;
        }
        
        //Metodo para cambiar el tamaño al formulario en tiempo de ejecución
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
        //Dibuja rectangulo/excluir esquinas paneles
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

        private void CerrarPictureBox_Click(object sender, EventArgs e)     //Envía un MessageBox para confirmar si desea cerrar la aplicación
        {
            DialogResult cerrar = MessageBox.Show("¿Seguro que desea cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Capturar posición y tamaño antes de maximizar para restaurar
        int lx;
        int ly;
        int sw;
        int sh;
        private void MaximizarPictureBox_Click(object sender, EventArgs e)      //Metodo para ajustar el tamaño del formulario en pantalla completa
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

        private void RestaurarPictureBox_Click(object sender, EventArgs e)    //Método que devuelve el form al tamaño anterior
        {
            MaximizarPictureBox.Visible = true;
            RestaurarPictureBox.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]        //Funciones para perminir el movimiento del formulario
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void BarraSuperiorPanel_MouseMove(object sender, MouseEventArgs e)      //Permite el movimiento del form
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MinimizarPictureBox_Click(object sender, EventArgs e)      //Minimiza el formulario
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AgregarButton_Click(object sender, EventArgs e)        //Agrega cuadernos nuevos o notas nuevas
        {
            if (AgregarButton.Text == "Agregar cuaderno")
            {
                CrearForm guardado = new CrearForm(idUsuario, nombreUsuario, historial);        //Genera el formulario de creacion de cuadernos 
                guardado.Show();        //Muestra el formularios de creacion de cuadernos
                this.Hide();
                historial.Add("Se intento agregar un cuaderno.");
            }
            else if (AgregarButton.Text == "Agregar nota")
            {
                CreacionNotas creacion = new CreacionNotas(idUsuario, nombreUsuario, Convert.ToInt32(AgregarButton.Tag),historial);
                creacion.Show();
                this.Hide();
                historial.Add("Se intento agregar una nota.");
            }
        }

        private void MenuFormulario_Load(object sender, EventArgs e)  
        {
            UsuarioLabel.Text = nombreUsuario;
            RecibeIdCuaderno(idUsuario);
            for (int i = 0; i < listaCuaderno.GetCountLista(); i++)     //Cuenta los elementos de la lista cuadernos
            {
                DibujarCuadernos(listaCuaderno.ConsultaCuaderno(i), i); //Dibuja los cuadernos en el panel
            }
            if (iniciarSesion)
            {
                historial.Add(nombreUsuario + " inicio sesión.");   //Agrega un elemento a la lista que contiene el historial de acciones
                iniciarSesion = false;
            }
            DerechaPanel.Visible = false;
        }

        private void CerrarSesiónButton_Click(object sender, EventArgs e)       //Cierra sesión
        {
            DialogResult cerrar = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)
            {
                this.Close();
                LoginForm login = new LoginForm();
                login.Show();
                iniciarSesion = true;
            }
        }
        public void DibujarCuadernos(Cuaderno cuaderno, int conteo)      //Método que dibuja los cuadernos que posee el usuario 
        {                                                                //Se le otorgan las propiedades al botón
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
            portada.AccessibleName = cuaderno.titulo;
            portada.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            portada.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            portada.Click += new EventHandler(handlerComun_Click);                      //Se le da el evento Click en tiemppo de ejecución
            InferiozIzquierdoPanel.Controls.Add(portada);                           //Se agrega el botón en el panel izquierdo del formulario
        }
        public void CargarCuadernos(int idCuaderno)     //Le da valores a los cuadernos y los agrega a la lista de cuadernos
        {
            string titulo = "";
            string categoria = "";
            string color = "";
            MySqlAccess acceso = new MySqlAccess();
            MySqlCommand command = new MySqlCommand(string.Format("SELECT titulo, categoria, color FROM Cuadernos where id_cuaderno = '{0}'", idCuaderno));
            var connection = acceso.GetConnection();
            connection.Open();
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();       //Se saca la información de la base de datos
            while (reader.Read())
            {
                titulo = reader.GetString(0);
                categoria = reader.GetString(1);
                color = reader.GetString(2);
            }
            Cuaderno cuaderno = new Cuaderno(idCuaderno, idUsuario, titulo, categoria, color);
            listaCuaderno.Agregar(cuaderno);                       //Se agrega a la lista el cuaderno creado
        }

        public void RecibeIdCuaderno(int idUsuario)     //Recibe el id de los cuadernos sacado de la base de datos
        {
            MySqlAccess acceso = new MySqlAccess();
            MySqlCommand command = new MySqlCommand(string.Format("SELECT id_cuaderno FROM Cuadernos where usuario = '{0}'", idUsuario));
            var connection = acceso.GetConnection();
            connection.Open();
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();       
            while (reader.Read())                   //Siempre y cuando hayan cuadernos se carga su id
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
        private void handlerComun_Click(object sender, EventArgs e)     //Método que permite usar el evento click en todos los cuadernos creados
        {
            Encriptar encriptar = new Encriptar();
            MySqlAccess acceso = new MySqlAccess();
            MySqlCommand command;
            var connection = acceso.GetConnection();
            connection.Open();
            MySqlDataReader reader;
            if (eliminarCuaderno)  //Si previamente se presiono el botón elminar cuaderno, permite eliminarlo presionando en el. Se eliminan primero las notas y luego el cuaderno
            {
                eliminarCuaderno = false;
                eliminarNota = false;
                command = new MySqlCommand(string.Format("delete from Notas where cuaderno = '{0}'", ((Button)sender).Tag));    //Se elimina la nota en la base de datos según el cuaderno seleccionado
                command.Connection = connection;
                reader = command.ExecuteReader();
                connection.Close();
                connection.Open();
                command = new MySqlCommand(string.Format("delete from Cuadernos where id_cuaderno = '{0}'", ((Button)sender).Tag)); //Elimina el cuaderno de la base de datos
                command.Connection = connection;
                reader = command.ExecuteReader();
                historial.Add("Se eliminó el cuaderno " + ((Button)sender).AccessibleName);
                this.Close();
                MenuFormulario menu = new MenuFormulario(idUsuario, nombreUsuario, historial, iniciarSesion);
                menu.Show();
            }
            else if (modificarCuaderno == true)     //Permite modificar el cuaderno
            {
                CrearForm form = new CrearForm(idUsuario, nombreUsuario, historial, modificarCuaderno, Convert.ToInt32(((Button)sender).Tag), ((Button)sender).AccessibleName);
                modificarCuaderno = false;
                modificarNota = false;
                this.Hide();
                form.Show();
            }
            else
            {
                CentroPanel.Controls.Clear();  
                listaNotas.DeleteLista();
                AgregarButton.Text = "Agregar nota";        //Se cambian los textos de los botones 
                EliminarButton.Text = "Eliminar nota";
                ModificarButton.Text = "Modificar nota";
                AgregarButton.Tag = ((Button)sender).Tag;         
                RecibeIdNota(Convert.ToInt32(AgregarButton.Tag.ToString()));
                for (int i = 0; i < listaNotas.GetCountNota(); i++)
                {
                    DibujarNotas(listaNotas.ConsultaNotas(i), i);       
                }
                historial.Add("Entro al cuaderno " + ((Button)sender).AccessibleName);
            }

        }
        public void CargarNotas(int idNota, int idCuaderno)     //Agrega una nota a la base de datos con su informacion y agrega la nota a la lista de notas
        {
            string titulo = "";
            string categoria = "";
            string texto = "";
            string fechaCreacion = "";
            string fechaModificacion = "";
            MySqlAccess acceso = new MySqlAccess();
            MySqlCommand command = new MySqlCommand(string.Format("SELECT titulo, categoria, fecha_creacion, fecha_modificacion, texto FROM Notas where id_nota = '{0}'", idNota));
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
                texto = reader.GetString(4);
            }
            Nota nota = new Nota(idNota, idCuaderno, titulo, categoria, texto, fechaCreacion, fechaModificacion);
            listaNotas.Agregar(nota);
        }

        public void RecibeIdNota(int idCuaderno)       //Recibe el id de la nota
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
            int x = 20;
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
            portada.Tag = nota.idNota.ToString();
            portada.FlatStyle = FlatStyle.Flat;
            portada.AccessibleName = nota.titulo;
            portada.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            portada.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            portada.Click += new EventHandler(handlerNotas_Click);
            CentroPanel.Controls.Add(portada);
        }
        private void handlerNotas_Click(object sender, EventArgs e)     //Metodo que permite usar el evento click en todas las notas creados
        {              
            Encriptar encriptar = new Encriptar();
            MySqlAccess acceso = new MySqlAccess();
            MySqlCommand command;
            var connection = acceso.GetConnection();
            connection.Open();
            MySqlDataReader reader;
            NotaRichTextBox.Tag = ((Button)sender).Tag;
            if (eliminarNota)
            {
                eliminarCuaderno = false;
                eliminarNota = false;
                command = new MySqlCommand(string.Format("delete from Notas where id_nota = '{0}'", ((Button)sender).Tag));
                command.Connection = connection;
                reader = command.ExecuteReader();
                historial.Add("Se eliminó la nota " + ((Button)sender).AccessibleName);
                this.Close();
                MenuFormulario menu = new MenuFormulario(idUsuario, nombreUsuario,historial,iniciarSesion);
                menu.Show();
            }
            else if (modificarNota)
            {
                CreacionNotas crear = new CreacionNotas(idUsuario, nombreUsuario, historial, modificarNota, Convert.ToInt32(((Button)sender).Tag), ((Button)sender).AccessibleName);
                modificarCuaderno = false;
                modificarNota = false;
                this.Hide();
                crear.Show();
            }
            else
            {   
                string informacionNota = "";
                command = new MySqlCommand(string.Format("SELECT texto FROM Notas where id_nota = '{0}'", ((Button)sender).Tag));
                command.Connection = connection;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    informacionNota = (reader.GetString(0));
                }
                if (visibleNota)
                {
                    DialogResult confirmar = MessageBox.Show("¿Desea guardar antes de salir?", "Confirmación", MessageBoxButtons.YesNo);
                    if (confirmar == DialogResult.Yes)
                    {
                        NotaRichTextBox.Text = encriptar.Desencriptamiento(informacionNota);
                        DerechaPanel.Visible = true;
                        historial.Add("Entro a la nota " + ((Button)sender).AccessibleName);
                        command = new MySqlCommand(string.Format("update Notas set texto = '{0}' where id_nota = '{1}'", encriptar.Encriptamiento(NotaRichTextBox.Text), NotaRichTextBox.Tag));
                        command.Connection = connection;
                        command.ExecuteReader();
                    }
                    else
                    {
                        NotaRichTextBox.Text = encriptar.Desencriptamiento(informacionNota);
                        DerechaPanel.Visible = true;
                        historial.Add("Entro a la nota " + ((Button)sender).AccessibleName);
                    }
                }
                else
                {
                    NotaRichTextBox.Text = encriptar.Desencriptamiento(informacionNota);
                    DerechaPanel.Visible = true;
                    visibleNota = true;
                    historial.Add("Entro a la nota " + ((Button)sender).AccessibleName);
                }
            }
        }
        private void AbrirFormulario<TextoForm>() where TextoForm : Form, new()
        {
            Form editor;
            editor = DerechaPanel.Controls.OfType<TextoForm>().FirstOrDefault(); //Busca en la colección el formulario
            if(editor == null)
            {
                editor = new TextoForm();
                editor.TopLevel = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (AgregarButton.Text == "Agregar nota") 
            {
                AgregarButton.Text = "Agregar cuaderno";
                EliminarButton.Text = "Eliminar cuaderno";
                ModificarButton.Text = "Modificar cuaderno";
                CentroPanel.Controls.Clear();
            }
            else if (NotaRichTextBox.Text != "")
            {
                DialogResult cerrar = MessageBox.Show("¿Desea guardar antes de salir?", "Confirmación", MessageBoxButtons.YesNo);
                if (cerrar == DialogResult.Yes)     //En caso que desee guardar cambios
                {
                    Encriptar encriptar = new Encriptar();
                    MySqlAccess acceso = new MySqlAccess();
                    MySqlCommand command = new MySqlCommand(string.Format("update Notas set texto = '{0}' where id_nota = '{1}'", encriptar.Encriptamiento(NotaRichTextBox.Text), NotaRichTextBox.Tag));
                    var connection = acceso.GetConnection();
                    connection.Open();
                    command.Connection = connection;
                    command.ExecuteReader();
                }
                else if (cerrar == DialogResult.No)     //En caso que desee salir sin guardar o haya guardado antes de presionar el boton cerrar
                {
                    this.Hide();
                }
                DerechaPanel.Visible = false;
            }

        }

        private void HistoriaButton_Click(object sender, EventArgs e)
        {
            string variable = "";
            for(int i = 0; i < historial.Count; i++)
            {
                variable = variable + historial[i] + "\n";
            }
            MessageBox.Show(variable);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (EliminarButton.Text == "Eliminar cuaderno")
            {
                MessageBox.Show("Haga click en el cuaderno que desea eliminar");
                eliminarCuaderno = true;
            }
            else if (EliminarButton.Text == "Eliminar nota")
            {
                MessageBox.Show("Haga click en la nota que desea eliminar");
                eliminarNota = true;
            }
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encriptar encriptar = new Encriptar();
            MySqlAccess acceso = new MySqlAccess();
            MySqlCommand command = new MySqlCommand(string.Format("update Notas set texto = '{0}' where id_nota = '{1}'", encriptar.Encriptamiento(NotaRichTextBox.Text), NotaRichTextBox.Tag));
            var connection = acceso.GetConnection();
            connection.Open();
            command.Connection = connection;
            command.ExecuteReader();
        }

        private void FormatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formato = FormatoDialog.ShowDialog();     //Abre un dialogo de formato
            if (formato == DialogResult.OK)     //Recibe una respuesta
            {
                NotaRichTextBox.Font = FormatoDialog.Font;      //Realiza los cambios en las notas
            }
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c1 = ColorDialog.ShowDialog();     //Abre un dialogo de color
            if (c1 == DialogResult.OK)      //Recibe una respuesta
            {
                NotaRichTextBox.ForeColor = ColorDialog.Color;       //Realiza los cambios en las notas
            }
        }

        private void AtrásToolStripMenuItem_Click(object sender, EventArgs e)       //Funcion del botón atras de editor de notas
        {
            NotaRichTextBox.Undo();
        }

        private void AdelanteToolStripMenuItem_Click(object sender, EventArgs e)        //Funcion del botón adelante de editor de notas
        {
            NotaRichTextBox.Redo();
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)      //Funcion del botón copiar de editor de notas
        {
            NotaRichTextBox.Copy();
        }

        private void PegarToolStripMenuItem_Click(object sender, EventArgs e)       //Funcion del botón pegar de editor de notas
        {
            NotaRichTextBox.Paste();
        }

        private void CortarToolStripMenuItem_Click(object sender, EventArgs e)      //Funcion del botón cortar de editor de notas
        {
            NotaRichTextBox.Cut();
        }

        private void SeleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)     //Funcion del botón Seleccionar todo de editor de notas
        {
            NotaRichTextBox.SelectAll();
        }

        private void EliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)        //Funcion del botón eliminar todo de editor de notas
        {
            NotaRichTextBox.Clear();
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)      //Funcion del botón cerrar de editor de notas
        {
            DialogResult cerrar = MessageBox.Show("¿Desea guardar antes de salir?", "Confirmación", MessageBoxButtons.YesNoCancel);
            if (cerrar == DialogResult.Yes)     //En caso que desee guardar cambios
            {
                Encriptar encriptar = new Encriptar();
                MySqlAccess acceso = new MySqlAccess();
                MySqlCommand command = new MySqlCommand(string.Format("update Notas set texto = '{0}' where id_nota = '{1}'", encriptar.Encriptamiento(NotaRichTextBox.Text), NotaRichTextBox.Tag));
                var connection = acceso.GetConnection();
                connection.Open();
                command.Connection = connection;
                command.ExecuteReader();
                DerechaPanel.Visible = false;
            }
            else if (cerrar == DialogResult.No)     //En caso que desee salir sin guardar o haya guardado antes de presionar el boton cerrar
            {
                DerechaPanel.Visible = false;
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)      //Función de los botones que modifican las notas y cuadernos
        {
            if(ModificarButton.Text == "Modificar cuaderno")
            {
                MessageBox.Show("Haga click en el cuaderno que desea modificar");
                modificarCuaderno = true;
            }
            else if(ModificarButton.Text == "Modificar nota")
            {
                MessageBox.Show("Haga click en la nota que desea modificar");
                modificarNota = true;
            }
        }
    }
}