using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            var curso = "Curso de C# desde cero";

            Console.WriteLine("Cadena 1 {0} ", curso.Substring(9));

            Console.WriteLine("Cadena 2 {0} ", curso.Substring(9, 11));

            var sub = curso.Replace("desde cero", "net core");
            Console.WriteLine("Cadena 3 {0}", sub);

            sub = curso.Remove(5);
            Console.WriteLine("Cadena 4 {0}", sub);

            sub = curso.Remove(5,11);
            Console.WriteLine("Cadena 5 {0}", sub);
            
            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
