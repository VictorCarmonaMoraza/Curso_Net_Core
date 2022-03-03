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
            lista.Add("Victor");
            lista.Add(32);
            lista.Add("Victor");
            lista.Add(true);
            lista.Add("Victor");
            lista.Add(true);
            

            //Insertar un dato en la posicion 2
            lista.Insert(2, "Cristiano Ronaldo");

            //Limpia toda la lista
            //lista.Clear();

            //Obtiene el ultimo elemento de l lista
            Console.WriteLine(lista.LastIndexOf("Victor"));

            Console.WriteLine("Revertir una lista");
            //Revierte la lista de como es originalmente
            lista.Reverse();

            Console.WriteLine(lista.Contains(32)+"---->");

            //Comprobamos que un elemento existe en la lista
            Console.WriteLine(lista.Exists(e => e.Equals("Victor")));


            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(lista.Count);
            Console.ReadKey();
        }
    }
}
