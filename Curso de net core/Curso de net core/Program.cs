﻿using System;
using System.Collections.Generic;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ListaNodo();
            list.ListaVacia();
            list.addNodo(1);
            list.addNodo(3);
            list.addNodo(2);
            list.addNodo(4);
            //list.Listar();
            ////list.DeletePrimero();
            //Console.WriteLine();
            //list.Listar();
            //Console.WriteLine();
            ////list.DeleteUltimo();
            //list.Listar();
            //list.DeletePosicionNodo(3);
            //list.Listar();
            //list.BuscarNodo(3);
            Console.WriteLine(list.Size());
            list.Sustituir(3, 6);
            list.Listar();
            
            Console.ReadKey();
        }
    }
}
