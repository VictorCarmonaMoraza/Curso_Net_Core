using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            var curso = "Curso de C# desde cero";
            //Nos devuelve la posicion del elemento
            var data = curso.IndexOf("#");
            Console.WriteLine(data);

            //Nos devuelve la poscion de la palabra
            var data2 = curso.IndexOf("desde");
            Console.WriteLine(data2);

            //Convierte la cadena de etxto en un array de char
            var data3 = curso.ToCharArray();
            //Recorremos el array de char
            for (int i = 0; i < data3.Length; i++)
            {
                Console.Write("{0},",data3[i]);
            }
            Console.WriteLine("");

            //Comparacion
            var name = "Alex";
            var data4 = curso.Equals(name);
            Console.WriteLine(data4);
            
            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
