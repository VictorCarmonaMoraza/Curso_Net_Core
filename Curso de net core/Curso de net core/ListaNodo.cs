using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_net_core
{
    public class ListaNodo
    {
        private Nodo primero;
        private int size;

        public ListaNodo()
        {
            this.primero = null;
            this.size = 0;
        }

        /// <summary>
        /// Metodo para añadir un nodo
        /// </summary>
        /// <param name="dato"></param>
        public void addNodo(int dato)
        {
            //Cada vez que se llame al metodo se creara un nuevo nodo
            Nodo nuevo = new Nodo(dato);
            Nodo valor1, valor2;
            if (primero == null)
            {
                primero = nuevo;
                nuevo.siguiente = null;
            }
        }
    }
}
