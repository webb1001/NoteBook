using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notebook.UNA.Cuaderno;

namespace Notebook
{
    public partial class GuardadoForm : Form
    {
        public Cuaderno Cuaderno1;
        public GuardadoForm()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Cuaderno1 = new Cuaderno();
            Cuaderno1.Crear(NombreTextBox.Text, CategoriaTextBox.Text, IdentificarColor());
        }
        public int IdentificarColor()
        {
            if (VerdeRadioButton.Checked == true)
            {
                return 2;
            }
            else if (AzulRadioButton.Checked == true)
            {
                return 3;
            }
            else if (AmarilloRadioButton.Checked == true)
            {
                return 4;
            }
            else if (CafeRadioButton.Checked == true)
            {
                return 5;
            }
            else 
            {
                return 1;
            }
        }
    }
}
