using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.UNA.Nota
{
    public class Nota
    {
        public int idNota;
        public int cuaderno;
        public string titulo;
        public string categoria;
        public string texto;
        public string fechaCreacion;
        public string fechaModificacion;

        Nota() { }
        public Nota(int idNota, int cuaderno, string titulo, string categoria, string texto, string fechaCreacion, string fechaModificacion)
        {
            this.idNota = idNota;
            this.cuaderno = cuaderno;
            this.titulo = titulo;
            this.categoria = categoria;
            this.fechaCreacion = fechaCreacion;
            this.fechaModificacion = fechaModificacion;
        }
    }
}
