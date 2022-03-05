using System;

namespace Curso_de_net_core
{
    class Program : Menu
    {

        private string variable;

        public Program(string s):base(s)
        {
            variable = s;
        }

        static void Main(string[] args)
        {
            new Program("Real betis").getProducto();
            Console.ReadKey();
        }

        ////Sobreescribimos el metodo del padre
        //public override void getProducto()
        //{
        //    Console.WriteLine(variable+" hija");
        //}
    }
}
