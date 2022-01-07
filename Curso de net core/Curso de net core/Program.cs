using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 3;
            int valor2 = 6;
            var suma = valor1 + valor2;
            Console.WriteLine("la suma es: "+$"{suma}");
            Console.WriteLine("la suma es: {0} ", suma);
            Console.WriteLine("");

            var resta = valor1 - valor2;
            Console.WriteLine("la resta es: " + $"{resta}");
            Console.WriteLine("la resta es: {0} ", resta);
            Console.WriteLine("");

            var multiplicacion = valor1 * valor2;
            Console.WriteLine("la multiplicacion es: " + $"{multiplicacion}");
            Console.WriteLine("la multiplicacion es: {0} ", multiplicacion);
            Console.WriteLine("");

            var division = valor1 / valor2;
            Console.WriteLine("la division es: " + $"{division}");
            Console.WriteLine("la division es: {0} ", division);
            Console.WriteLine("");

            //Para que no se oculta la consola
            Console.ReadLine();

        }
    }
}
