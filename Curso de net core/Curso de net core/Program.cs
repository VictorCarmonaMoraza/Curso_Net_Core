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
            lista.Add(true);
            //Console.WriteLine(lista[0]);
            //lista.Remove(32);

            Console.WriteLine("-------Forma reducida--------");
            lista.ForEach(item => Console.WriteLine(item));

            //Insertar un dato en la posicion 2
            lista.Insert(2, "Cristiano Ronaldo");
            Console.WriteLine(lista.IndexOf(32));
            Console.WriteLine(lista.IndexOf(32,2));
            Console.WriteLine(lista.IndexOf(32,0,3));

            Console.WriteLine("-------Forma tradicional--------");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(lista.Count);
            Console.ReadKey();
        }
    }
}
