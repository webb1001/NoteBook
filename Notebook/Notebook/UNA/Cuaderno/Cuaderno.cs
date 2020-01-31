using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.UNA.Cuaderno
{
    public class Cuaderno
    {
        public int idCuaderno;
        public int idUsuario;
        public string titulo;
        public string categoria;
        public string color;

        public Cuaderno(){}
        public Cuaderno(int id_cuaderno, int id_usuario, string titulo, string categoria, string color)
        {
            this.idCuaderno = id_cuaderno;
            this.idUsuario = id_usuario;
            this.titulo = titulo;
            this.categoria = categoria;
            this.color = color;
        }
    }
}
