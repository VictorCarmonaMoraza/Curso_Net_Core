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
            var data = valor1 < valor2;

            Console.WriteLine("Resultado {0} ", data);
            //Console.WriteLine("Resultado " + $"{division}");
            Console.WriteLine("");

            //Para que no se oculta la consola
            Console.ReadLine();

        }
    }
}
