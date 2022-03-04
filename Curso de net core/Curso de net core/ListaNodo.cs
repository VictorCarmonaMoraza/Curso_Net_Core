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
                while (valor1 != null)
                {
                    valor2 = valor1.siguiente;
                    //Condicion que verifica si el numero entrnte debe ir primero
                    if (nuevo.dato <= valor1.dato)
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                        break;
                    }
                    else
                    {
                        //Condicion que verifica si el numero entrante debe ir al ultimo
                        if (nuevo.dato > valor1.dato && valor2 == null)
                        {
                            valor1.siguiente = nuevo;
                            nuevo.siguiente = null;
                            break;
                        }
                        else
                        {
                            //Condicion que verifica si el numero entrante debe ir en medio de otro nodo
                            if (valor1.dato < nuevo.dato && valor2.dato >= nuevo.dato)
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
            //Para saber la cantidad de nodos
            size++;
        }

        /// <summary>
        /// Comprobaqcion de si la lista contiene datos
        /// </summary>
        public void ListaVacia()
        {
            if (primero == null)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Console.WriteLine("la lista contiene datos");
            }
        }

        /// <summary>
        /// Lista todos los valores de nodos
        /// </summary>
        public void Listar()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.Write($"[{actual.dato}]->");
                actual = actual.siguiente;
            }
        }

        /// <summary>
        /// Elimina el primer nodo de la coleccion
        /// </summary>
        public void DeletePrimero()
        {
            //Sustituye el primeor por el segundo y ya no se muestra 
            primero = primero.siguiente;
        }

        public void DeleteUltimo()
        {
            Nodo actual = primero;

            while (actual.siguiente != null)
            {
                Console.Write($"[{actual.dato}]->");
                actual = actual.siguiente;
            }
        }

        public void DeleteUltimoV2()
        {
            Nodo anterior = primero;
            Nodo actual = primero;

            while (actual.siguiente != null)
            {
                anterior = actual;
                actual = actual.siguiente;
            }
            anterior.siguiente = null;
        }

        public void DeletePosicionNodo(int p)
        {
            Nodo anterior = primero;
            Nodo actual = primero;
            int dato = 0;
            if (p > 0)
            {
                while (dato!=p && actual.siguiente !=null)
                {
                    anterior = actual;
                    actual = actual.siguiente;
                    dato++;
                }
                anterior.siguiente = actual.siguiente;
            }
        }

        public Nodo BuscarNodo(int n)
        {
            Nodo p = primero;

            if (p == null)
            {
                Console.WriteLine("La lista no tiene datos");
            }
            else
            {
                while(p.siguiente!=null || p.siguiente == null)
                {
                    if (p.dato == n)
                    {
                        return p;
                    }
                    else
                    {
                        if (p.siguiente == null)
                        {
                            return null;
                        }
                    }
                    p = p.siguiente;
                }
            }
            return null;
        }

        public void Sustituir(int orig, int nuevoDato)
        {
            Nodo pos = BuscarNodo(orig);
            if(pos !=null || pos == null)
            {
                pos.dato = nuevoDato;
            }
        }

        //Devuleve la cantidad de nodos
        public int Size()
        {
            return size;
        }
       
    }
}
