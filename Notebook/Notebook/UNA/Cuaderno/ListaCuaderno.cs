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
        //public bool Verificar(string usuario, string contraseña)
        //{
        //    bool encontrado = false;
        //    int i = 0;
        //    while (encontrado == false && i < listaCuadernos.Count)
        //    {
        //        if (listaCuadernos[i].NombreUsuario == usuario && listaCuadernos[i].Contraseña == contraseña)
        //        {
        //            encontrado = true;
        //        }
        //        else
        //        {
        //            i++;
        //        }
        //    }
        //    return encontrado;
        //}
    }
}
