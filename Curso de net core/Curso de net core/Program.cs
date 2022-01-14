using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un array de tipo entero
            int[] age= new int[5];

            //Almacenamos datos en las posiciones de un array de tipo entero
            age[0] = 5;
            age[1] = 15;
            age[2] = 50;
            age[3] = 55;
            age[4] = 95;

            //Imprimimos una poscion del array
            Console.WriteLine("Resultado {0}", age[0] + " - " + age[3] +" - " +age[2]);

            //Inicializar un array con datos por defecto
            int[] dia = { 4, 25, 35, 98, 31 };
            Console.WriteLine("Resultado {0}", dia[0] + " - " + dia[1] + " - " + dia[3]);

            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
