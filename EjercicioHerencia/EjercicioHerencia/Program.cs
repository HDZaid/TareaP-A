using EjercicioHerencia;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace Tienda 
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Electronico> electronicos = new List<Electronico>();
            Console.WriteLine("TIENDA DE ELECTRODOMESTICOS");
            MenuPrincipal(electronicos);
        }

        static void MenuPrincipal(List<Electronico>electronicos)
        {
            bool opcionWhile = true;
            while (opcionWhile)
            {
                Console.WriteLine("MENU PRINCIPAL:");
                Console.WriteLine("[ 1 ] AGREGAR NUEVO PRODUCTO ");
                Console.WriteLine("[ 2 ] MOSTRAR PRODUCTOS");
                Console.WriteLine("[ 3 ] BUSCAR PRODUCTOS");
                Console.WriteLine("[ 4 ] Salir:");
                int opcion = 0;
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("AGREGAR NUEVOS PRODUCTODS");
                        SegundoMenu(electronicos);
                        break;
                        

                    case 2:
                        Console.WriteLine("MOSTRAR TODOS LOS OBJETOS");
                        MostrarObjetos(electronicos);
                        break; 

                    case 3:
                        Console.WriteLine("BUSCAR PRODUCTO POR NOMBRE");
                        BuscarElectronicos(electronicos);
                        break;
                    case 4:
                        opcionWhile=false;
                        break;
                }
            }
        }
        static void SegundoMenu(List<Electronico> electronicos)
        {
            bool opcionWhile = true;
            int opcionswitch = 0;

            while (opcionWhile)
            {
                Console.WriteLine("Que objeto nuevo quiere ingresar?");
                Console.WriteLine("[ 1 ]NUEVO TELEFONO");
                Console.WriteLine("[ 2 ]NUEVO ORDENADOR");
                Console.WriteLine("[ 3 ]NUEVA TABLET");
                Console.WriteLine("[ 4 ]REGRESAR");
                opcionswitch = Convert.ToInt32(Console.ReadLine());
                switch (opcionswitch)
                {
                    case 1:
                        Telefono telefono = new Telefono();
                        telefono.PedirDatosTelefono();
                        electronicos.Add(telefono);
                        break;

                    case 2:
                        Ordenador ordenador = new Ordenador();
                        ordenador.PedirDatosOrdenador();
                        electronicos.Add(ordenador);
                        break;

                    case 3:
                        Tablet tablet = new Tablet();
                        tablet.PedirDatosTablet();
                        electronicos.Add(tablet);
                        break;
                    case 4:
                        opcionWhile = false;
                        break;
                } 
            }
        }
        static void MostrarObjetos(List<Electronico> electronicos) 
        {
            foreach (Electronico electronico in electronicos)
            {
                Console.WriteLine("\n");
                Console.WriteLine("----------------------------------------------");
         
                if (electronico is Telefono telefono)
                {
                    Console.WriteLine("\t\t\t");
                    telefono.MostrarDatosTelefono();
                }
                
                else if (electronico is Ordenador ordenador)
                {
                    Console.WriteLine("\t\t\t");
                    ordenador.MostrarDatosOrdenador();
                }
                else if (electronico is Tablet tablet)
                {
                    Console.WriteLine("\t\t\t");
                    tablet.MostrarDatosTablet();
                }
            }
            Console.WriteLine("\n");
        }

        static void BuscarElectronicos(List<Electronico> electronicos) 
        {
            Console.WriteLine("INGRESE EL NOMBRE DEL PRODUCTO QUE BUSCA");
            string productoBuscado = Console.ReadLine();
            foreach (Electronico electronico in electronicos)
            {
                if (electronico.Nombre == productoBuscado)
                {
                    Console.WriteLine("EL PRODUCTO ES:");
                    if (electronico is Telefono telefono)
                    {
                        Console.WriteLine("\t\t\t");
                        telefono.MostrarDatosTelefono();
                    }

                    else if (electronico is Ordenador ordenador)
                    {
                        Console.WriteLine("\t\t\t");
                        ordenador.MostrarDatosOrdenador();
                    }
                    else if (electronico is Tablet tablet)
                    {
                        Console.WriteLine("\t\t\t");
                        tablet.MostrarDatosTablet();
                    }
                }
            }
        }
    }
}