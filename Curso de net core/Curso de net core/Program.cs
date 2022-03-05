using System;

namespace Curso_de_net_core
{
    class Program : Menu
    {

        static void Main(string[] args)
        {
            ////Esto es polimorfismo
            //Almacen a1 = new Golosinas();
            new Program().start();
            Console.ReadKey();
        }

        private void start()
        {
            golosinas();
        }

        ////Sobreescribimos el metodo del padre
        //public override void getProducto()
        //{
        //    Console.WriteLine(variable+" hija");
        //}
    }
}
