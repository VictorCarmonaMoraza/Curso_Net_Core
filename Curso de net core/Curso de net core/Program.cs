using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            var nombre = (nombre1: "Alex",age1: 24,nombre2:"Victor");

            //Interpolacion de cadenas de ipo string
            Console.WriteLine($"{nombre.nombre1} age {nombre.age1}");

            //Formato compuesto
            Console.WriteLine("Nombre {0} age {1}", nombre.nombre2, nombre.age1);
            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
