using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos variable
            var data = 5;

            switch (data)
            {
                case 5:
                    Console.WriteLine("Este es el numero que viene en la data y es {0}", data);
                    break;
                case 4:
                    Console.WriteLine("Este es el numero que viene en la data y es {0}", data);
                    break;

                default:
                    Console.WriteLine("Este es el numero que viene en la data y es el numero {0}", data);
                    break;
            }




            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
