using System;

namespace Curso_de_net_core
{
    public class Menu:IMenu
    {
        Almacen g = new Golosinas();

        public void golosinas()
        {
            var opcion = "";
            var valor = false;

            do
            {
                //Limpiamos consola
                Console.Clear();
                Console.WriteLine("Venta de Golosinas");
                if (g.getProducto().Count.Equals(0))
                {
                    Console.WriteLine("No hay golosinas");
                    Console.WriteLine("¿Desea agregar golosinas?, presione la tecla s/n");
                    opcion = Console.ReadLine().ToUpper();
                    if (opcion.Equals("S"))
                    {
                        Console.WriteLine("¿Cuantas golosinas va a agregar?");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                    }
                }

            } while (valor);
        }

        public double solicitarPago()
        {
            throw new NotImplementedException();
        }

        public void ventas()
        {
            throw new NotImplementedException();
        }
    }
}
