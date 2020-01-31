using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notebook.UNA.MySql;

namespace Notebook
{
    public partial class CreacionNotas : Form
    {
        int idUsuario = 0;
        int idCuaderno = 0;
        string nombreUsuario = "";
        string tituloNota = "";
        string categoriaNota = "";
        string fechaCreacion = "";
        string fechaModificacion = "";
        public CreacionNotas(int idUsuario, string nombreUsuario, int idCuaderno)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.idCuaderno = idCuaderno;
            MessageBox.Show(idCuaderno.ToString());
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuFormulario menu = new MenuFormulario(idUsuario, nombreUsuario);
            menu.Show();
        }

        private void TituloTextBox_Enter(object sender, EventArgs e)
        {
            if (TituloTextBox.Text == "TÍTULO")
            {
                TituloTextBox.Text = "";
                TituloTextBox.ForeColor = Color.LightGray;
            }
        }

        private void TituloTextBox_Leave(object sender, EventArgs e)
        {
            if (TituloTextBox.Text == "")
            {
                TituloTextBox.Text = "TÍTULO";
                TituloTextBox.ForeColor = Color.DimGray;
            }
        }

        private void CategoriaTextBox_Enter(object sender, EventArgs e)
        {
            if (CategoriaTextBox.Text == "CATEGORÍA")
            {
                CategoriaTextBox.Text = "";
                CategoriaTextBox.ForeColor = Color.LightGray;
            }
        }

        private void CategoriaTextBox_Leave(object sender, EventArgs e)
        {
            if (CategoriaTextBox.Text == "")
            {
                CategoriaTextBox.Text = "CATEGORÍA";
                CategoriaTextBox.ForeColor = Color.DimGray;
            }
        }

        private void LimpiarErrorProvider()     //Limpia el errorProvider de los textBox
        {
            NotasErrorProvider.SetError(TituloTextBox, "");
            NotasErrorProvider.SetError(CategoriaTextBox, "");
        }

        private bool InformacionEsValida()      //Verifica que todos los textbox contengan informacion
        {
            LimpiarErrorProvider();
            bool esValida = true;
            if (TituloTextBox.Text == "" || TituloTextBox.Text =="TÍTULO")
            {
                esValida = false;
                NotasErrorProvider.SetError(TituloTextBox, "Debe especificar un nombre para la nota");
            }
            if (CategoriaTextBox.Text == "" || CategoriaTextBox.Text == "CATEGORÍA")
            {
                esValida = false;
                NotasErrorProvider.SetError(CategoriaTextBox, "Debe especificar una categoria para la nota");
            }
            return esValida;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            tituloNota = TituloTextBox.Text;
            categoriaNota = CategoriaTextBox.Text;
            fechaCreacion = DateTime.Now.ToString();
            string texto = "";

            if (TituloTextBox.Text == "Nombre" || CategoriaTextBox.Text == "Categoría")
            {
                InformacionEsValida();
                MessageBox.Show("Faltan datos.");
            }
            else if (InformacionEsValida())
            {
                MySqlAccess acceso = new MySqlAccess();
                acceso.OpenConnection();
                acceso.EjectSQL(string.Format("insert into Notas(cuaderno,titulo,fecha_creacion, fecha_modificacion, categoria, texto) values('{0}','{1}','{2}','{3}','{4}','{5}')", idCuaderno, tituloNota, fechaCreacion, fechaModificacion, categoriaNota,texto));
                acceso.CloseConnection();
                MessageBox.Show("Se ha creado el cuaderno con éxito.");
                MenuFormulario form = new MenuFormulario(idUsuario, nombreUsuario);
                this.Close();
                form.Show();
            }
        }

        private void CreadorNotasPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
