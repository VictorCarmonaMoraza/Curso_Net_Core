using System;
using System.Collections.Generic;

namespace Curso_de_net_core
{
    public abstract class Almacen
    {
        public abstract List<Producto> getProducto();

        public abstract void addProducto(Producto producto);
    }
}
