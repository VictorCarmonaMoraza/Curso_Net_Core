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
            //Verificamos si el nodo es nulo
            if (primero == null)
            {
                primero = nuevo;
                nuevo.siguiente = null;
            }
            else
            {
                valor1 = primero;
                while (valor1!=null)
                {
                    valor2 = valor1.siguiente;
                    //Condicion que verifica si el numero entrnte debe ir primero
                    if (nuevo.dato<=valor1.dato)
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                        break;
                    }
                    else
                    {
                        //Condicion que verifica si el numero entrante debe ir al ultimo
                        if(nuevo.dato>valor1.dato && valor2 == null)
                        {
                            valor1.siguiente = nuevo;
                            nuevo.siguiente = null;
                            break;
                        }
                        else
                        {
                            //Condicion que verifica si el numero entrante debe ir en medio de otro nodo
                            if(valor1.dato<nuevo.dato && valor2.dato >= nuevo.dato)
                            {
                                valor1.siguiente = nuevo;
                                nuevo.siguiente = valor2;
                                break;
                            }
                            else
                            {
                                valor1 = valor1.siguiente;
                            }
                        }
                    }
                }
            }
        }
    }
}
