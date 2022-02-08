using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Program();
            //Llamamos al metodo con dos parametros, aunque sean tres pero el ultimo es opcional
            //por lo tanto no tenemos error, pero por defecto le estamos asignando el valor 69
            data.metodo("C#", "Victor");
            data.metodo("C#", "Victor",115);
        }

        private void metodo(String curso, string nombre, int cantidad = 69)
        {
            //Aqui devolvera 69 porque se asigan el que tiene por defecto
            Console.WriteLine(cantidad);
        }

        private void metodo2(String curso, string nombre, int cantidad = 69)
        {
            //Aqui devolvera 115 porque se lo hemos puesto en los argumentos de 
            //llamada al metodo
            Console.WriteLine(cantidad);
        }
    }
}
