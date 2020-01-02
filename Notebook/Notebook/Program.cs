using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook.UNA.Usuario
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            Usuario Persona1 = new Usuario("Alejandro","Primo2K20","cacademono");
            Usuario Persona2 = new Usuario("Christopher", "Webb2K20", "cacadeperro");
            Usuario Persona3 = new Usuario("Profe", "Profe", "Profe");


        }
    }
}
