using System;
using System.Collections.Generic;

namespace Tienda
{

    class Program
    {
        static List<Producto> productos = new List<Producto>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------->[Menú]<--------");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. cambiar precio");
                Console.WriteLine("4. eliminar producto");
                Console.WriteLine("5. buscar producto");
                Console.WriteLine("6. realizar venta");
                Console.WriteLine("7. salir ");


                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarProducto();
                        break;
                    case 2:
                        MostrarProductos();
                        break;
                    case 7:
                        return;
                    case 4:
                        EliminarProducto();
                        break;
                    case 5:
                        BuscarProducto();
                        break;
                    case 6:
                        RealizarVenta();
                        break;
                    case 3:
                        CambiarPrecio();
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        static void AgregarProducto()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad en stock: ");
            int cantidad = int.Parse(Console.ReadLine());

            Producto nuevoProducto = new Producto(nombre, precio, cantidad);
            productos.Add(nuevoProducto);
            Console.WriteLine("Producto agregado correctamente.");
        }

        static void MostrarProductos()
        {
            Console.WriteLine("Lista de productos:");
            foreach (Producto producto in productos)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}, Precio: {producto.Precio}, Cantidad: {producto.CantidadEnStock}");
            }
        }

        static void EliminarProducto()
        {
            Console.Write("Ingrese el nombre del producto a eliminar: ");
            string nombre = Console.ReadLine();

            for (int i = productos.Count - 1; i >= 0; i--)
            {
                if (productos[i].Nombre == nombre)
                {
                    productos.RemoveAt(i);
                    Console.WriteLine("Producto eliminado correctamente.");
                    return; 
                }
            }

            Console.WriteLine("Producto no encontrado.");
        }

        static void BuscarProducto()
        {
            Console.Write("Ingrese el nombre del producto a buscar: ");
            string nombre = Console.ReadLine();

            foreach (var producto in productos)
            {
                if (producto.Nombre.Contains(nombre))
                {
                    Console.WriteLine($"Nombre: {producto.Nombre}, Precio: {producto.Precio}, Cantidad: {producto.CantidadEnStock}");
                }
            }
        }

        static void RealizarVenta()
        {
            Console.Write("Ingrese el nombre del producto a vender: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad a vender: ");
            int cantidadAVender = int.Parse(Console.ReadLine());

            bool productoEncontrado = false;

            foreach (var producto in productos)
            {
                if (producto.Nombre == nombre)
                {
                    if (producto.CantidadEnStock >= cantidadAVender)
                    {
                        producto.CantidadEnStock -= cantidadAVender;
                        Console.WriteLine("Venta realizada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No hay suficiente stock.");
                    }
                    productoEncontrado = true;
                    break; // Salimos del bucle una vez que encontramos el producto
                }
            }

            if (!productoEncontrado)
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        static void CambiarPrecio()
        {
            Console.Write("Ingrese el nombre del producto a cambiar precio: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la variacion del producto + o -: ");
            int nuevoPrecio = int.Parse(Console.ReadLine());

            bool productoEncontrado = false;

            foreach (var producto in productos)
            {
                if (producto.Nombre == nombre)
                {
                    producto.Precio += nuevoPrecio;

                    if (producto.Precio >=0 )
                    {
                        
                        Console.WriteLine("Cambio de Precio Realizado.");
                    }
                    else
                    {
                        producto.Precio -= nuevoPrecio;
                        Console.WriteLine("El precio no puede ser menor que 0.");
                    }
                    productoEncontrado = true;
                    break; 
                }
            }

            if (!productoEncontrado)
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

    }
}