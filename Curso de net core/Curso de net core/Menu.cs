using System;

namespace Curso_de_net_core
{
    public class Menu : Principal, IProductos
    {
        private string s;

        public Menu(string s)
        {
            this.s = s;
            base.getProducto();
        }

        public void addProductos()
        {
            throw new NotImplementedException();
        }

        //public override void getProducto()
        //{
        //    Console.WriteLine(s);
        //}

        //protected virtual void getProducto()
        //{
        //    Console.WriteLine(s + " Padre");
        //}
    }
}
