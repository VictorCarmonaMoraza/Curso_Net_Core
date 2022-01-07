using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores de igualdad
            int valor1 = 9;
            int valor2 = 9;
            var data = valor1 != valor2;


            if (data)
            {
                Console.WriteLine("Resultado {0} ", data);
            }
            
            //Console.WriteLine("Resultado " + $"{division}");
            //Console.WriteLine("");

            //Para que no se oculta la consola
            Console.ReadLine();

        }
    }
}
