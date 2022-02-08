using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object[] parametros = { "Victor", 25, true };
            //new Program().metodo("Victor", 25, true, 'A');

            int edad = 30;
            int data = 67;
            //reflejara el valor de data fuera del metodo, aqui vale 70
            new Program().metodo(ref data);
            //Con esto no tenemos que inicializar la variable data
            new Program().metodo2(out data);
            Console.WriteLine(data);
            Console.ReadLine();
        }

        private void metodo(ref int valor)
        {
            valor = 50 + 20;
            //Console.WriteLine(valor);
        }

        private void metodo2(out int valor)
        {
            valor = 50 + 20;
            //Console.WriteLine(valor);
        }
    }
}
