using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una lista de objetos
            var (a, b, opcion) = (2, 6, "+");
            var resultado = opcion switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b
            };

            Console.WriteLine("Resultado {0}", resultado);

            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
