using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_net_core
{
    public class Nodo
    {
        public int dato;
        public Nodo siguiente;

        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
    }
}
