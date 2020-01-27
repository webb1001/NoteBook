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

namespace Notebook
{
    public partial class MenuForm : Form
    {
        StreamReader lector;        //Permite leer los .txt
        string cadena;      //Se usa para almacenar el contenido del .txt
        string[] campos = new string[47];       //Mediante el caracter " ° " separa el contenido de cadena 
        string nombreUsuario = "";      //Almacena el nombre de usuario
        char[] separador = { '°' };     //Almacena el caracter usado como separador
        public MenuForm()
        {
            InitializeComponent();
        }
        public void LeerArchivo()       //Permite leer todo el archivo .txt del usuario y otorga datos a las variables
        {
            try
            {
                lector = File.OpenText(nombreUsuario + ".txt");     //Abre el archivo .txt
                cadena = lector.ReadToEnd();        //Lee todo el archivo .txt
                campos = cadena.Split(separador);       //Divide a cadena mediante el separador y lo almacena en campos
                lector.Close();     //Cierra la lectura del archivo 
            }
            catch (FileNotFoundException fe)        //Muestra un mensaje en caso de error
            {
                MessageBox.Show("Error" + fe.Message);
            }
            catch (Exception en)
            {
                MessageBox.Show("Error" + en.Message);
            }
        }
        public MenuForm(string nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario; 
            InitializeComponent();
        }
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)       //Verifica que haya espacio para almacenar cuadernos y en ese caso los crea o no 
        {
            LeerArchivo();      //Actualiza los valores de las variables
            if (Convert.ToInt32(campos[1].Trim()) == 9)     //Verifica que se pueda crear un nuevo cuaderno
            {
                MessageBox.Show("Ya alcanzó su limite de cuadernos, elimine un cuaderno si desea crear uno nuevo.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                CrearForm guardado = new CrearForm(nombreUsuario);        //Genera el formulario de creacion de cuadernos 
                guardado.Show();        //Muestra el formularios de creacion de cuadernos
                this.Hide();        //Esconde el formulario actual
            }
        }
        private void MenuForm_Load(object sender, EventArgs e)      //Carga el formulario
        {
            LeerArchivo();      //Actualiza las variables relacionadas al .txt
            DibujarCategoria();     //Dibija etiquetas con las categorias de los cuadernos
            DibujarCuadernos();     //Dibuja cuadernos con sus respectivos nombres
        }
        public Image ColorCuaderno(int idCuaderno)       //Especifica la caracteristica color de los cuadernos
        {
            LeerArchivo();
            Image imagen;       //Genera un objeto de tipo imagen
            if (campos[idCuaderno * 4 + 4].Trim().ToString() == "Rojo")
            {
                imagen = Image.FromFile("CuR.png");     //Si su caracteristica color coincide con "Rojo"
            }
            else if (campos[idCuaderno * 4 + 4].Trim().ToString() == "Azul")
            {
                imagen = Image.FromFile("CuadernoAzul.png");     //Si su caracteristica color coincide con "Azul"
            }
            else if (campos[idCuaderno * 4 + 4].Trim().ToString() == "Amarillo")
            {
                imagen = Image.FromFile("CuAM.png");        //Si su caracteristica color coincide con "Amarillo"
            }
            else if (campos[idCuaderno * 4 + 4].Trim().ToString() == "Cafe")
            {
                imagen = Image.FromFile("CuC.png");     //Si su caracteristica color coincide con "Cafe"
            }
            else
            {
                imagen = Image.FromFile("CuV.png");     //Si su caracteristica color coincide con "Verde"
            }
            return imagen;      //Se retorna la imagen con el color adquirido
        }
        public void DibujarCuadernos()      //Metodo que dibuja los cuadernos que posee el usuario 
        {
            LeerArchivo();
            Image cuadernoImagen;
            int x = 75;
            int y = 55;
            int aux = 0;
            int conteo = 1;
            if (Convert.ToInt32(campos[1]) != 0)
            {
                for (int i = 0; i < Convert.ToInt32(campos[1]); i++)
                {
                    Label cuaderno = new Label();
                    cuadernoImagen = ColorCuaderno(i);
                    cuaderno.AutoSize = false;
                    cuaderno.Name = "CuadernoLabel" + conteo.ToString();
                    cuaderno.Text = campos[i * 4 + 2].Trim();
                    cuaderno.Width = 80;
                    cuaderno.Height = 110;
                    cuaderno.Left = x;
                    cuaderno.Top = y;
                    cuaderno.Image = cuadernoImagen;
                    cuaderno.BackColor = Color.Transparent;
                    //Agregar que la imagen sea stretch...
                    cuaderno.Click += new EventHandler(handlerComun_Click);
                    EstanteriaPanel.Controls.Add(cuaderno);
                    x += 150;
                    aux++;
                    if (aux == 3 || aux == 6)
                    {
                        x = 75;
                        y += 138;
                    }
                    conteo++;
                }
            }
        }
        private void handlerComun_Click(object sender, EventArgs e)     //Metodo que permite usar el evento click en todos los cuadernos creados
        {
            if(((Label)sender).Name == "CuadernoLabel1")        //Si se hace click en el cuaderno 1, abre su contenido
            {
                EditorDeNotas cuaderno = new EditorDeNotas(nombreUsuario, 1);
                cuaderno.Show();
                this.Hide();
            }
            if (((Label)sender).Name == "CuadernoLabel2")       //Si se hace click en el cuaderno 2, abre su contenido
            {
                EditorDeNotas cuaderno = new EditorDeNotas(nombreUsuario, 2);
                cuaderno.Show();
                this.Hide();
            }
            if (((Label)sender).Name == "CuadernoLabel3")       //Si se hace click en el cuaderno 3, abre su contenido
            {
                EditorDeNotas cuaderno = new EditorDeNotas(nombreUsuario, 3);
                cuaderno.Show();
                this.Hide();
            }
            if (((Label)sender).Name == "CuadernoLabel4")       //Si se hace click en el cuaderno 4, abre su contenido
            {
                EditorDeNotas cuaderno = new EditorDeNotas(nombreUsuario, 4);
                cuaderno.Show();
                this.Hide();
            }
            if (((Label)sender).Name == "CuadernoLabel5")       //Si se hace click en el cuaderno 5, abre su contenido
            {
                EditorDeNotas cuaderno = new EditorDeNotas(nombreUsuario, 5);
                cuaderno.Show();
                this.Hide();
            }
            if (((Label)sender).Name == "CuadernoLabel6")       //Si se hace click en el cuaderno 6, abre su contenido
            {
                EditorDeNotas cuaderno = new EditorDeNotas(nombreUsuario, 6);
                cuaderno.Show();
                this.Hide();
            }
            if (((Label)sender).Name == "CuadernoLabel7")       //Si se hace click en el cuaderno 7, abre su contenido
            {
                EditorDeNotas cuaderno = new EditorDeNotas(nombreUsuario, 7);
                cuaderno.Show();
                this.Hide();
            }
            if (((Label)sender).Name == "CuadernoLabel8")       //Si se hace click en el cuaderno 8, abre su contenido
            {
                EditorDeNotas cuaderno = new EditorDeNotas(nombreUsuario, 8);
                cuaderno.Show();
                this.Hide();
            }
            if (((Label)sender).Name == "CuadernoLabel9")       //Si se hace click en el cuaderno 9, abre su contenido
            {
                EditorDeNotas cuaderno = new EditorDeNotas(nombreUsuario, 9);
                cuaderno.Show();
                this.Hide();
            }
        }
        public void DibujarCategoria()      //Metodo que dibuja las etiquetas de los cuadernos que poseen los usuarios
        {
            LeerArchivo();
            int x = 75;
            int y = 30;
            int aux = 0;
            if (Convert.ToInt32(campos[1])!=0)
            {
                for (int i = 0; i < Convert.ToInt32(campos[1]); i++)
                {
                    Label etiqueta = new Label();
                    etiqueta.AutoSize = true;
                    etiqueta.Text = campos[i * 4 + 3].Trim();
                    etiqueta.Left = x;
                    etiqueta.Top = y;
                    etiqueta.BackColor = Color.Transparent;
                    EstanteriaPanel.Controls.Add(etiqueta);
                    x += 150;
                    aux++;
                    if (aux == 3 || aux == 6)
                    {
                        y += 140;
                        x = 75;
                    }
                }
            }           
        }
        private void CerrarSesioButton_Click(object sender, EventArgs e)        //Permite cambiar de usuario o simplemente cerrar sesion
        {
            DialogResult cerrar = MessageBox.Show("¿Desea cerrar sesion?", "Confirmación", MessageBoxButtons.YesNo);
            if (cerrar == DialogResult.Yes)
            {
                this.Dispose();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
    }
}
