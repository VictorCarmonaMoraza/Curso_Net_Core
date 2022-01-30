using System;
using System.Text;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //Agregar contenido a la cadena de texto
            var names2 = new StringBuilder("Victor Carmona");
            //Metodo que ejecutara un salto de linea
            names2.AppendLine(" ");
            names2.Append("Moraza").Append(" ").Append("Diaz");
            names2.AppendLine(" ");
            names2.AppendFormat("Age {0}",50);
            Console.WriteLine(names2.ToString());

            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
