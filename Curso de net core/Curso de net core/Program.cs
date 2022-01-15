using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estamos creando un array multidimensional de 3 filas y 2 columnas
            double[,] bidimensional = new double[3, 2] { { 6, 3.0 }, { 7, 5.1 }, { 8, 4.7 } };
            //esrtamos creando un array tridimensioanl con 2 filas, 2 columnas y tres datos en cada columna
            double[,,] tridmensional = new double[2, 2, 3] { { { 3.0, 6.9, 8.9 }, { 6.8, 4.5, 7.6 } }, { { 7.0, 5.9, 1.9 }, { 9.8, 15.5, 78.6 } } };

            //Imrprimimos la poscion que queremos
            Console.WriteLine("Resultado {0}", bidimensional[1, 1]);
            Console.WriteLine("Resultado {0}", tridmensional[1, 1, 1]);

            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
