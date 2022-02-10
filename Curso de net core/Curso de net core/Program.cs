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
            data.metodo("C#",cantidad:32);
            data.metodo2(curso:"C#",cantidad:32, nombre:"Victor Carmona");
            data.metodo3(null, null);
            
            
        }

        private void metodo(String curso, int cantidad, string nombre="Victor")
        {
            //Aqui devolvera 69 porque se asigan el que tiene por defecto
            Console.WriteLine($"{curso} {cantidad}");
        }

        private void metodo2(String curso, int cantidad, string nombre)
        {
            //Aqui devolvera 69 porque se asigan el que tiene por defecto
            Console.WriteLine(cantidad);
        }

        private void metodo3(String curso, int? cantidad, string nombre="Jorge")
        {
            //Aqui devolvera 69 porque se asigan el que tiene por defecto
            Console.WriteLine(cantidad);
        }
    }
}
