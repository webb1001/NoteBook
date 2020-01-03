using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.UNA.Usuario
{
    public class ListaUsuario
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        public void Agregar(Usuario modelo)
        {
            listaUsuarios.Add(modelo);
        }
        public List<Usuario> Consultar()
        {
            return listaUsuarios;
        }
    }
}
