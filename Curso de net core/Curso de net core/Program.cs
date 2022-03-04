using System;
using System.Collections.Generic;

namespace Curso_de_net_core
{
    class Program : Menu
    {
        static void Main(string[] args)
        {
            new Program().getProducto();
            Console.ReadKey();
        }
    }
}
