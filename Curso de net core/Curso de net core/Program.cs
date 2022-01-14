using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //creacion de un array de tipo string
            string[] cadenas = new string[5];
            cadenas[0] = "Alex";
            cadenas[1] = "Carlos";
            cadenas[2] = "Alejandro";
            cadenas[3] = "Alba";
            cadenas[4] = "Lucia";

            //Inicializacion de un array
            string[] name = { "Alex","Carlos", "Alejandro", "Alba", "Lucia" };

            //Imprimimos la longitud del array
            Console.WriteLine("Resultado {0} ", cadenas.Length);

            //Imprimimos la posicion 4 del array que sera la ultima a la que podemos asignar valores
            Console.WriteLine("Resultado {0} ", cadenas[4]);

            //Concatenamos posiciones de array cadenas
            Console.WriteLine("Resultado {0} ", cadenas[0] + " "+ cadenas[3]);

            //Concatenamos posiciones de array name
            Console.WriteLine("Resultado {0} ", name[0] + " " + name[3]);

            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();

        }
    }
}
