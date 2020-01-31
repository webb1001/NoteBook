using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.UNA.Nota
{
    class ListaNotas
    {
        List<Nota> listaNotas = new List<Nota>();
        public void Agregar(Nota modelo)
        {
            listaNotas.Add(modelo);
        }
        public List<Nota> Consultar()
        {
            return listaNotas;
        }
        public Nota ConsultaNotas(int contadorNotas)
        { 
            return listaNotas[contadorNotas];
        }
        public int GetCountNota()
        {
            return listaNotas.Count();
        }

        public void DeleteLista()
        {
            listaNotas.Clear();
        }
    }
}
