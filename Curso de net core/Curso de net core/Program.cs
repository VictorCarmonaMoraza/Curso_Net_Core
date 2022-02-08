using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object[] parametros = { "Victor", 25, true };
            //new Program().metodo("Victor", 25, true, 'A');

            int edad = 30;
            new Program().metodo2(edad);
            Console.ReadLine();
        }

        private void metodo2(in int valor)
        {
            //valor = 50;
            Console.WriteLine(valor);
        }

        //al poner params no nos dara error porque los captura
        private void metodo(params object[] parametros)
        {
            //Casteamos los que nos viene en la posiscion cero del arreglo
            string nombre = (string)parametros[0];
            int edad = (int)parametros[1];
            bool valor = (bool)parametros[2];

            //Recorrido con un foreach
            foreach (var item in parametros)
            {
                Console.WriteLine(item);
            }
        }

        private void RecorrerArreglo(object[] parametros)
        {
            //Recorremos el arreglo
            for (int i = 0; i < parametros.Length; i++)
            {
                Console.WriteLine(i + "---->" + parametros[i]);
            }
        }
    }
}
