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
        //   int x = 0;
        //   int y = 0;
        StreamReader lector;
        string cadena;
        string[] campos = new string[47];
        string nombreUsuario = "";
        char[] separador = { '°' };

        public MenuForm()
        {
            InitializeComponent();
        }
        public void LeerArchivo()
        {
            try
            {
                lector = File.OpenText(nombreUsuario + ".txt");
                cadena = lector.ReadToEnd();
                campos = cadena.Split(separador);
                lector.Close();
            }
            catch (FileNotFoundException fe)
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

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeerArchivo();
            if (Convert.ToInt32(campos[1].Trim()) == 9)
            {
                MessageBox.Show("Ya alcanzó su limite de cuadernos, elimine un cuaderno si desea crear uno nuevo.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                GuardadoForm guardado = new GuardadoForm(nombreUsuario);
                guardado.Show();
                this.Hide();
            }
            //campos[1] = Convert.ToString();
        }

        private void Guardado_pasado(string nombre, string categoria, string color)
        {
            throw new NotImplementedException();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            LeerArchivo();
            DibujarCategoria();
            DibujarCuadernos();
        }

        public Image ColorCuaderno(int i)
        {
            LeerArchivo();
            Image imagen;
            if (campos[i * 4 + 4].Trim().ToString() == "Rojo")
            {
                imagen = Image.FromFile("CuR.png");
            }
            else if (campos[i * 4 + 4].Trim().ToString() == "Azul")
            {
                imagen = Image.FromFile("CuA.png");
            }
            else if (campos[i * 4 + 4].Trim().ToString() == "Amarillo")
            {
                imagen = Image.FromFile("CuAM.png");
            }
            else if (campos[i * 4 + 4].Trim().ToString() == "Cafe")
            {
                imagen = Image.FromFile("CuC.png");
            }
            else
            {
                imagen = Image.FromFile("CuV.png");
            }
            return imagen;
        }
        public void DibujarCuadernos()
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
                    //Agregar que la imagen sea stetch...
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
        private void handlerComun_Click(object sender, EventArgs e)
        {
            //cerrar
            if(((Label)sender).Name == "CuadernoLabel1")
            {
                EditorDeTexto cuaderno = new EditorDeTexto(nombreUsuario, 1);
                cuaderno.Show();
            }
            if (((Label)sender).Name == "CuadernoLabel2")
            {
                EditorDeTexto cuaderno = new EditorDeTexto(nombreUsuario, 2);
                cuaderno.Show();
            }
            if (((Label)sender).Name == "CuadernoLabel3")
            {
                EditorDeTexto cuaderno = new EditorDeTexto(nombreUsuario, 3);
                cuaderno.Show();
            }
            if (((Label)sender).Name == "CuadernoLabel4")
            {
                EditorDeTexto cuaderno = new EditorDeTexto(nombreUsuario, 4);
                cuaderno.Show();
            }
            if (((Label)sender).Name == "CuadernoLabel5")
            {
                EditorDeTexto cuaderno = new EditorDeTexto(nombreUsuario, 5);
                cuaderno.Show();
            }
            if (((Label)sender).Name == "CuadernoLabel6")
            {
                EditorDeTexto cuaderno = new EditorDeTexto(nombreUsuario, 6);
                cuaderno.Show();
            }
            if (((Label)sender).Name == "CuadernoLabel7")
            {
                EditorDeTexto cuaderno = new EditorDeTexto(nombreUsuario, 7);
                cuaderno.Show();
            }
            if (((Label)sender).Name == "CuadernoLabel8")
            {
                EditorDeTexto cuaderno = new EditorDeTexto(nombreUsuario, 8);
                cuaderno.Show();
            }
            if (((Label)sender).Name == "CuadernoLabel9")
            {
                EditorDeTexto cuaderno = new EditorDeTexto(nombreUsuario, 9);
                cuaderno.Show();
            }
        }
        public void DibujarCategoria()
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
    }
}
