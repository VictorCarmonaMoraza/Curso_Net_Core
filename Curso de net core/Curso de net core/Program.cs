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
            string name;
            var data = valor1 != valor2;

            //if (data)
            //{
            //    name = "Alex";
            //}
            //else
            //{
            //    name = "Joel";
            //}
            name = data ? "Alex" : "Joel";
            Console.WriteLine("Resultado {0} ", name);

            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();

        }
    }
}
