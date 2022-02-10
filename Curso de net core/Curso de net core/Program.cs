using System;

namespace Curso_de_net_core
{
    class Program
    {
        //Es solo de lectura pero no le podremos asignar valor
        readonly int valor = 23;
        //Forzosamente debemos inicializar las constantes
        const int VALOR2 = 98;

        //Solo podemos modificar su valor en los constructores
        public Program()
        {
            valor = 10;
        }

        static void Main(string[] args)
        {
            var data = new Program();
            Console.WriteLine($"{data.valor}");


        }
    }
}
