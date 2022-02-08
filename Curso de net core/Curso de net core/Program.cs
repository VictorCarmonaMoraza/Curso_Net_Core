using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //int data;
            string nombre;
            //new Program().metodo(out data);
            mensaje();
            Console.WriteLine(nombre);
            void mensaje() => nombre = "Victor Carmona";
            Console.ReadLine();
        }

        private void metodo(out int valor)
        {
            valor = funcion();

            //Si tenemos un metodo static con una linea de codigo podemos hacer la funcion flecha
            static int funcion()=> 50 + 20;
        }
    }
}
