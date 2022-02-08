using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            int data;
            new Program().metodo(out data);
            
            Console.WriteLine(data);
            Console.ReadLine();
        }

        private void metodo(out int valor)
        {
            valor = 50 + 20;
            var valor2 = funcion3();
            Console.WriteLine(valor2);
            funcion(valor);
            funcion2(valor);
            

            int funcion(int valor)
            {
                Console.WriteLine($"Hola soy una funcion {valor}");
                return valor;
            }

            void funcion2(int valor)
            {
                Console.WriteLine($"Hola soy una funcion void {valor}");
            }

            int funcion3()
            {
                return 50 + 20;
            }
        }
    }
}
