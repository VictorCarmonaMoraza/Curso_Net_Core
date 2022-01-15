using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Resultado {0}", i); 
            }
            Console.WriteLine("-------------------------");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Resultado {0}", i);
            }

            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
