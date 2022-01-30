using System;
using System.Text;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Program(); //Tambien es valido--> Program data = new Program();
            data.metodoPrivado();
            metodoPrivado2();
            Console.ReadLine();
            //Console.ReadKey();
        }

        private  void metodoPrivado()
        {
            Console.WriteLine("Metodo privado con instancia");
        }

        private static void metodoPrivado2()
        {
            Console.WriteLine("Metodo privado son instanciar");
        }
    }
}
