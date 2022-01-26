using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos una variable de tipo bool
            var valor = true;
            var count = 1;
            while (valor)
            {
                if (count == 6)
                {
                    valor = false;
                }
                count++;
                Console.WriteLine("Ejeccion de while {0}", count);
            }
            //---------------------------

            valor = true;
            count = 1;
            //Por lo menos una vez entra una vez
            do
            {
                if (count == 6)
                {
                    valor = false;
                }
                count++;
                Console.WriteLine("Ejecucion de do while {0}", count);

            } while (valor);

            valor = true;
            count = 1;
            //Por lo menos una vez entra una vez
            do
            {
                if (count == 6)
                {
                    //Podemos parar la ejecucion con la palabra break
                    //Esta palabra para toda la ejecucion y ya no se ejecuta ninguna linea mas hacia abajo
                    break;
                }
                count++;
                Console.WriteLine("Ejecucion de do while con break {0}", count);

            } while (valor);

            //Para que no se oculta la consola
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
