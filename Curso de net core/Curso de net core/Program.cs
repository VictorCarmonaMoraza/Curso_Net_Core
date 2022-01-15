using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos variable
            var data = 2;
            var resultado = data switch
            {
                1 => "Alex",
                2 => "Victor",
                3 => "Lucia"
            };

            Console.WriteLine("Resultado {0}", resultado);

            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
