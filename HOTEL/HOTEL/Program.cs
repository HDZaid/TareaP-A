using HOTEL;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace Tienda
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Habitacion> hotel = new List<Habitacion>();
            Console.WriteLine("HOTEL TIO NACHO");
            MenuPrincipal(hotel);
        }

        static void MenuPrincipal(List<Habitacion> hotel)
        {
            bool opcionWhile = true;
            while (opcionWhile)
            {
                Console.WriteLine("MENU PRINCIPAL:");
                Console.WriteLine("[ 1 ] AGREGAR HABITACION ");
                Console.WriteLine("[ 2 ] ELIMINAR HABITACION");
                Console.WriteLine("[ 3 ] MOSTRAR HABITACION");
                Console.WriteLine("[ 4 ] ASIGNAR HABITACION");
                Console.WriteLine("[ 5 ] LIBERAR HABITACION");
                Console.WriteLine("[ 6 ] Salir:");
                int opcion = 0;
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("AGREGAR HABITACION");
                        SegundoMenu(hotel);
                        break;

                    case 2:
                        Console.WriteLine("ELIMINAR HABITACION");

                        break;
                    case 3:
                        Console.WriteLine("MOSTRAR HABITACION");
                        break;
                    case 4:
                        Console.WriteLine("ASIGNAR HABITACION");
                        break;
                    case 5:
                        Console.WriteLine("LIBERAR HABITACION");
                        break;
                    case 6:
                        opcionWhile = false;
                        break;
                }
            }
        }
        static void SegundoMenu(List<Habitacion> hotel)
        {
            bool opcionWhile = true;
            int opcionswitch = 0;

            while (opcionWhile)
            {
                Console.WriteLine("Que objeto nuevo quiere ingresar?");
                Console.WriteLine("[ 1 ] SIMPLE");
                Console.WriteLine("[ 2 ] DOBLE");
                Console.WriteLine("[ 3 ] SUITE");
                Console.WriteLine("[ 4 ] DELUX");
                opcionswitch = Convert.ToInt32(Console.ReadLine());
                switch (opcionswitch)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                    case 4:
                        break;
                }
            }
        }/*
        static void MostrarObjetos(List<Habitacion> hotel)
        {
            foreach (Habitacion electronico in hotel)
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
    */
    }
}