using HOTEL;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace HOTEL
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Habitacion> hotel = new List<Habitacion>();
            Console.WriteLine("HOTEL TIO MILO");
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
                        MostrarHabitaciones(hotel);
                        break;
                    case 4:
                        Console.WriteLine("ASIGNAR HABITACION");
                        CondicionalDeAsignacion(hotel);
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
                Console.WriteLine("[ 5 ] salir");
                opcionswitch = Convert.ToInt32(Console.ReadLine());
                switch (opcionswitch)
                {
                    case 1:
                        HabitacionSimple habitacionSimple = new HabitacionSimple();
                        habitacionSimple.pedirDatosHabitacionSimple();
                        hotel.Add(habitacionSimple);
                        break;
                    case 2:
                        Doble habitacionDoble = new Doble();
                        habitacionDoble.MetodoVistaAlMar();
                        hotel.Add(habitacionDoble);
                        break;
                    case 3:
                        
                        break;
                    case 4:
                     
                        break;
                    case 5:
                        opcionWhile=false;
                        break;
                }
            }
        }
        static void MostrarHabitaciones(List<Habitacion> hotel)
        {
            foreach (Habitacion habitacion in hotel)
            {
                Console.WriteLine("\n");
                Console.WriteLine("----------------------------------------------");

                if (habitacion is HabitacionSimple habitacionSimple)
                {
                    Console.WriteLine("\t\t\t");    
                    habitacionSimple.MostrarInformacionHabitacionSimple();
                }
                /*
                else if (habitacion is Doble doble)
                {
                    Console.WriteLine("\t\t\t");
                    ordenador.MostrarDatosOrdenador();
                }
                else if (electronico is Tablet tablet)
                {
                    Console.WriteLine("\t\t\t");
                    tablet.MostrarDatosTablet();
                }*/
            }
            Console.WriteLine("\n");
        }
        static void BuscarElectronicos(List<Habitacion> hotel)
        {
            Console.WriteLine("INGRESE EL NOMBRE DEL PRODUCTO QUE BUSCA");
            int HabitacionBuscada = Convert.ToInt32(Console.ReadLine());
            foreach (Habitacion habitacion in hotel)
            {
                if (habitacion.NumeroHabitacion == HabitacionBuscada)
                {
                    Console.WriteLine("EL PRODUCTO ES:");
                    if (habitacion is HabitacionSimple habitacionSimple)
                    {
                        Console.WriteLine("\t\t\t"); //metodo de Mostrar habitacion simple
                        habitacionSimple.MostrarInformacionHabitacionSimple();
                    }
                    /*
                    else if (electronico is Ordenador ordenador) // lo mismo con todas las demas
                    {
                        Console.WriteLine("\t\t\t");
                        ordenador.MostrarDatosOrdenador();
                    }
                    else if (electronico is Tablet tablet)
                    {
                        Console.WriteLine("\t\t\t");
                        tablet.MostrarDatosTablet();
                    }*/
                }
                else
                {
                    Console.WriteLine("habitacion No encontrada");
                }
            }
        }

        static void MenuAsignarHabitacionCliente(List<Habitacion> hotel) 
        {
            bool opcionWhile = true;
            int opcionswitch = 0;

            while (opcionWhile)
            {
                Console.WriteLine("Que objeto nuevo quiere ingresar?");
                Console.WriteLine("[ 1 ] ASIGNAR HABITACION SIMPLE");
                Console.WriteLine("[ 2 ] ASIGNAR HABITACION DOBLE");
                Console.WriteLine("[ 3 ] ASIGNAR HABITACION SUITE");
                Console.WriteLine("[ 4 ] ASIGNAR HABITACION DELUX");
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
        }

        static void CondicionalDeAsignacion (List<Habitacion> hotel)
        {
            Console.WriteLine("Ingresa el numero de la habitacion que quieres asignar al cliente");
            int numeroDeHabitacionBuscada = Convert.ToInt32(Console.ReadLine());
            foreach (Habitacion habitacion in hotel)
            {
                if(habitacion is HabitacionSimple habitacionSimple)
                {
                    if (habitacion.NumeroHabitacion == numeroDeHabitacionBuscada)
                    {
                        Console.WriteLine("INGRESE EL NOMBRE DEL CLIENTE");
                        habitacion.AsignarCliente(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("NO ESTA ");
                    }
                }
            }
        }

        static void LiberarAsignacion()
        {

        }

    }
}
