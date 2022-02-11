using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Estudiante();
            var nombre = data.Nombre="Ana";
            var apellido = data.Apellido = "Benitez";
        }
    }
}
