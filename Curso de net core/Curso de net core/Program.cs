using System;

namespace Curso_de_net_core
{
    class Program
    {

        static void Main(string[] args)
        {
            //Esto es polimorfismo
            Almacen a1 = new Golosinas();

            Console.ReadKey();
        }

        ////Sobreescribimos el metodo del padre
        //public override void getProducto()
        //{
        //    Console.WriteLine(variable+" hija");
        //}
    }
}
