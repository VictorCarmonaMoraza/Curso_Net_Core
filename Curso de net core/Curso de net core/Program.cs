using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Ale";
            string name2 = "Victor";
            string name3 = name1;

            name1 += name2;
            Console.WriteLine("Name: {0}", name1);
            Console.WriteLine("Name: {0}", name3);

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
