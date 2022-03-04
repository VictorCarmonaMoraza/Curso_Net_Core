using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_net_core
{
    public class Menu
    {
        private string s;

        public Menu(string s)
        {
            this.s = s;
        }

        public virtual void getProducto()
        {
            Console.WriteLine(s+" Padre");
        }
    }
}
