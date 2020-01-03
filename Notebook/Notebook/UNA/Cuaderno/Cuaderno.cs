using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.UNA.Cuaderno
{
    public class Cuaderno
    {
        public string Nombre;
        public string Categoria;
        public int Color;
        public bool Guardado;

        public Cuaderno()
        {
            Nombre = "Cuaderno";
            Categoria = "Categoria";
            Color = 0;
            Guardado = false;
        }
        public void Crear(string nombre,string categoria,int color)
        {
            Nombre = nombre;
            Categoria = categoria;
            Color = color;
            Guardado = true;
        }
    }
}
