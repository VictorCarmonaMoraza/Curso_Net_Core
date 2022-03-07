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
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Nueva Golosina");
                            Console.WriteLine("Ingrese la id");
                            var id = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio");
                            var precio = Convert.ToDouble(Console.ReadLine());
                            g.addProducto(new Producto {
                                ID=id,
                                Nombre = nombre,
                                Precio = precio
                            });
                        }
                        Console.WriteLine("Desea ir al inicio?");
                        opcion = Console.ReadLine().ToUpper();
                        if (opcion.Equals("S"))
                        {
                            valor = true;
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Desea ir al inicio s/n");
                        opcion = Console.ReadLine().ToUpper();
                        if (opcion.Equals("S"))
                        {
                            Console.Clear();
                            Console.WriteLine("Venta de golosinas y frutas");
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lista de golosinas");
                    foreach (var item in g.getProducto())
                    {
                        Console.WriteLine($"Codigo {item.ID} Golosina {item.Nombre} Precio {item.Precio}");
                    }
                    Console.WriteLine("Desea realizar ventas de golosinas s/n");
                    opcion = Console.ReadLine().ToUpper();

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
