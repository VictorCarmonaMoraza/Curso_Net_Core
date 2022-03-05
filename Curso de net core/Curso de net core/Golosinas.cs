using System.Collections.Generic;

namespace Curso_de_net_core
{
    public class Golosinas : Almacen
    {
        private List<Producto> _Golosinas;

        public Golosinas()
        {
            _Golosinas = new List<Producto>();
        }

        public override void addProducto(Producto producto)
        {
            _Golosinas.Add(producto);
        }

        public override List<Producto> getProducto()
        {
            return _Golosinas;
        }
    }
}
