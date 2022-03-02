using Curso_de_net_core.model;
using System;
using System.Collections.Generic;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> lista = new List<Object>();
            //List<String> lista2 = new List<String>();
            lista.Add("Victor");
            lista.Add(32);
            Console.WriteLine(lista[0]);
            lista.Remove(32);
            Console.WriteLine(lista.Count);
            Console.ReadKey();
        }
    }
}
