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
            data.metodoPublico();
            data.metodoPrivado1();
            Console.WriteLine(data.metodoPrivado3());
            Console.WriteLine(data.metodoPrivado4());
            
            Console.ReadLine();
            //Console.ReadKey();
        }

        private void metodoPrivado()
        {
            Console.WriteLine("Metodo privado con instancia");
        }

        private string metodoPrivado1()
        {
            return "Victor Carmona";
        }

        private string metodoPrivado3()
        {
            return $"Victor Carmona {25}";
        }

        private int metodoPrivado4()
        {
            //Convierte un dato de tipo string en un dato de tipo entero
            return Convert.ToInt16("23");
        }

        public void metodoPublico()
        {
            Console.WriteLine("Victor");
        }
    }
}
