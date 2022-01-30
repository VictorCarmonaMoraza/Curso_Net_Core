using System;
using System.Text;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cambiar un caracter por otro en la cdena de texto
            var names = new StringBuilder("Victor Carmona");
            names[0] = 'R';
            Console.WriteLine(names.ToString());

            //Agregar contenido a la cadena de texto
            var names2 = new StringBuilder("Victor Carmona");
            names2.Append("");
            names2.Append("Moraza");
            Console.WriteLine(names2.ToString());

            //Obtener la longitud de la cadena de texto
            Console.WriteLine(names2.Length);

            //Cambiar la capacidad de nustra cadena de texto
            var names3 = new StringBuilder("Victor Carmona");
            // names3.Capacity=2;  //Esto provocara una excepcion
            names3.Capacity = 17;
            Console.WriteLine(names3.ToString());






            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
