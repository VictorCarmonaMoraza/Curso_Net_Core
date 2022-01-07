using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2022;

            Console.WriteLine("Hello Victor! " + year);

            //Otra forma de imprimir el valor de la variable
            int mes = 12;
            Console.WriteLine("Hello Victor! {0} ", mes);

            //Convertir tipo string en entero
            int xEntero = Convert.ToInt16("12");
            double decimales = 2.0;
            string nombre = "Joel";
            String nombres = "Alex Joel";
            decimal decimals = 2.07M;
            float flotante = 8.0F;
            Console.WriteLine("El valor decimals es: {0} ",decimals);
            Console.WriteLine("El valor decimals es: "+ $"{decimals}");
            Console.WriteLine(nombres + " {0} {1} {2}", xEntero, decimales, nombre);

            //Para que no se oculta la consola
            Console.ReadLine();

            //NOTA
            /*Para cantidades que tengan muchos decimales es mejor utilizar el
             * tipo de datos decimal porque el tipo decimal soporta 28-29 digitos
             * de 128 bits mientras que el double solo soporta 15-16 digitos de
             * 64 bits y el tipo float solo soporta 7 digitos de 32 bits.
             */
        }
    }
}
