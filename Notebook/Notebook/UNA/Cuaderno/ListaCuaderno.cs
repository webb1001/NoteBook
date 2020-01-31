using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.UNA.Cuaderno
{
    class ListaCuaderno
    {
        List<Cuaderno> listaCuadernos = new List<Cuaderno>();
        public void Agregar(Cuaderno modelo)
        {
            listaCuadernos.Add(modelo);
        }
        public List<Cuaderno> Consultar()
        {
            return listaCuadernos;
        }
        public Cuaderno ConsultaCuaderno(int contadorCuadernos)
        {
            return listaCuadernos[contadorCuadernos];
        }
        public int GetCountLista()
        {
            return listaCuadernos.Count();
        }

        public int ConsultaId(int contador)
        {
            return listaCuadernos[contador].idCuaderno;
        }
    }
}
