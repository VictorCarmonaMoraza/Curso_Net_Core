using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una array de tipo string
            string[] name = { "Alejandor", "Victor", "Carlos" };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Resultado {0}", name[i]);
            }
            Console.WriteLine("--------------------");
            foreach (var item in name)
            {
                Console.WriteLine("Resultado {0}", item);
            }

            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
