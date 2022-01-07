using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores de asignacion
            int valor1 = 9;
            int valor2 = 2;
            int valor3 = 6;
            int valor4 = 3;
            int valor5 = 9;
            int valor6 = 3;
            //Le sumamos al valor1 el valor2
            valor1 += valor2;
            valor3 -= valor4;
            Console.WriteLine("Resultado {0} ", valor1);
            Console.WriteLine("Resultado {0} ", valor3);
            //Console.WriteLine("Resultado " + $"{division}");
            Console.WriteLine("");

            //Obtenemos el resto de una division
            valor6 %= valor5;
            Console.WriteLine("Resultado {0} ", valor6);
            Console.WriteLine("");

            //Para que no se oculta la consola
            Console.ReadLine();

        }
    }
}
