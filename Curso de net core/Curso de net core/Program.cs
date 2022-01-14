using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores de igualdad
            int valor1 = 9;
            int valor2 = 98;
            double valor3 = 10;
            double valor4 = 11;
            var data = valor1 != valor2;

            if (valor1!=valor2 || valor3== valor4)
            {
                if (valor3 == valor4)
                {
                    Console.WriteLine("Resultado {0} ", "La comparacion devolvio un true");
                }
                else
                {
                    Console.WriteLine("Resultado {0} ", "La comparacion devolvio un false");
                }
                
            }
            else
            {
                Console.WriteLine("Resultado {0} ", data);
            }

            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();

        }
    }
}
