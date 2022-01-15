using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos una variable de tipo bool
            var valor = true;
            var count = 1;
            while (valor)
            {
                if (count == 6)
                {
                    valor = false;
                }
                count++;
                Console.WriteLine("Resultado {0}", count);
            }

            //Para que no se oculta la consola
            //Console.ReadLine();
             Console.ReadKey();
        }
    }
}
