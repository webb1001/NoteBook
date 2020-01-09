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

        public bool Verificar(string usuario, string contraseña)
        {
            bool encontrado = false;
            int i = 0;
            while (encontrado == false && i < listaUsuarios.Count)
            {
                if (listaUsuarios[i].NombreUsuario == usuario && listaUsuarios[i].Contraseña == contraseña)
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            return encontrado;
        }
    }
}
