using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor.velocidad = 3.0;
            Conversor.Conversor1();
            Conversor.Conversor2();

            int opcion, repetir = 0;
            var con = new Conversor2();

            do
            {
                Console.WriteLine("Escoja una de las opciones");
                Console.WriteLine("1 - Convertir m/s a km/h");
                Console.WriteLine("2 - Convertir km/h a m/s");
                //Obtenemos el valor ingresado por consola
                opcion = Convert.ToInt32(Console.ReadLine());
                //Este switch deberia ser mejor llevarselo a un metodo
                switch (opcion)
                {
                    case 1:
                        con.ConversorA();
                        break;
                    case 2:
                        con.ConversorB();
                        break;
                    default:
                        Console.WriteLine("opcion erronea");
                        break;
                }
                Console.WriteLine("Si desea repetir coloque el valor de 1 o cualquier tecla para salir");
                repetir = Convert.ToInt32(Console.ReadLine());
            } while (repetir == 1);
        }
    }
}
