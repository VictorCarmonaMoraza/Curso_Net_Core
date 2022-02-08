using System;

namespace Curso_de_net_core
{
    class Conversor2
    {
        private double velocidad;

        public void ConversorA()
        {
            Console.WriteLine("Introduzca una velocidad en m/s");
            //Convertimos un dato string que viene de la consola en un tipo double
            velocidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{velocidad} m/s =  { velocidad * 3600 / 1000} km/h");
        }

        public void ConversorB()
        {
            Console.WriteLine("Introduzca una velocidad en km/s");
            //Convertimos un dato string que viene de la consola en un tipo double
            velocidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{velocidad} km/h =  { velocidad * 1000 / 3600} m/s");
        }
    }
}
