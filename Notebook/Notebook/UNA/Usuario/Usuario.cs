using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.UNA.Usuario  
{
    public class Usuario
    {
        public string Nombre;
        public string NombreUsuario;
        public string Contraseña;

        public Usuario(string Nombre, string NombreUsuario, string Contraseña)
        {
            this.Nombre = Nombre;
            this.NombreUsuario = NombreUsuario;
            this.Contraseña = Contraseña;
        }
    }
}
