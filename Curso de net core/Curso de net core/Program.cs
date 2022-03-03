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

            Console.WriteLine("------Forma 1-------");
            lista.ForEach(item =>
            {
                Console.WriteLine(item);
            });

            Console.WriteLine("------Forma 2-------");
            for (int i = 0; i < lista.Count; i++)
            {
                //Console.WriteLine($"El elemento de la posicion {0} es:",i+" "+ lista[i]);
                Console.WriteLine( i +"=>"+lista[i]);
            }

            Console.WriteLine("------Forma 3-------");
            int j = 0;
            for(; ; )
            {
                if (j < lista.Count)
                {
                    Console.WriteLine(lista[j]);
                    j++;
                }
                else
                {
                    break;
                }
            }

            //Console.WriteLine(lista.Count);
            Console.ReadKey();
        }
    }
}
