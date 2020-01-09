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
    public partial class GuardadoForm : Form
    {
        StreamWriter escritor;
        StreamReader lector;
        string cadena;
        string nombreUsuario = "";
        string[] campos = new string[47];
        char[] separador = { '°' };
        public GuardadoForm(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
        }

        public void SobreescribirArchivo()
        {
            LeerArchivo();
            File.Delete(nombreUsuario + ".txt");
            StreamWriter escritor = new StreamWriter(nombreUsuario + ".txt");
            int aux = Convert.ToInt32(campos[1]);
            aux++;
            campos[1] = Convert.ToString(aux);
            for (int i = 0; i < campos.Length; i++)
            {
                campos[i] = campos[i] + "°";
                escritor.WriteLine(campos[i]);
            }
            escritor.Close();
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

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            LeerArchivo();
            SobreescribirArchivo();
            escritor = File.AppendText(nombreUsuario + ".txt");
            escritor.Write(NombreTextBox.Text + "°");
            escritor.Write(CategoriaTextBox.Text + "°");
            escritor.Write(IdentificarColor() + "°");
            escritor.Close();
            this.Hide();
            EditorDeTexto cuaderno = new EditorDeTexto(nombreUsuario);
            cuaderno.Show();
        }
        public string IdentificarColor()
        {
            if (VerdeRadioButton.Checked == true)
            {
                return "Verde";
            }
            else if (AzulRadioButton.Checked == true)
            {
                return "Azul";
            }
            else if (AmarilloRadioButton.Checked == true)
            {
                return "Amarillo";
            }
            else if (CafeRadioButton.Checked == true)
            {
                return "Cafe";
            }
            else 
            {
                return "Rojo";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menu = new MenuForm(nombreUsuario);
            menu.Show();
        }

        private void GuardadoForm_Load(object sender, EventArgs e)
        {
            LeerArchivo();
        }
    }
}
