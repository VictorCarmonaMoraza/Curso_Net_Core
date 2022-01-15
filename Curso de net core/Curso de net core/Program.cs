using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Altura del triangulo
            int pisos = 0;
            //Creamos una array de un posicion
            int[] arreglo = new int[1];

            //Mostramos un mensaje y capturarlo el dato ingresado desde la consola
            Console.WriteLine("Ingrese el numero de pisos");

            /*Obtener datos por consola y lo transformamos en enetero ya que todo lo que
             se captura por consola es como un string*/
            pisos = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i <= pisos; i++)
            {
                /*Colocamos un arreglo y colocamos la variable del ciclo for
                 que sera el tamaño que tendra el arreglo cada vez que el ciclo for
                se ejecute*/
                int[] pascal = new int[i];
                for (int j = pisos; j < i; j--)
                {
                    Console.WriteLine("");
                }
                //Ciclo for que genera las sumas de las cifras
                for (int k = 0; k < i; k++)
                {
                    //Condicion que evalua la variable del ciclo for
                    if(k==0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        /*Sumamos los numeros que estan en cada posicion
                         del arreglo para formar el triangulo*/
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    Console.Write("[" + pascal[k] + "]");
                }
                arreglo = pascal;
                Console.WriteLine(" ");
            }




            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
