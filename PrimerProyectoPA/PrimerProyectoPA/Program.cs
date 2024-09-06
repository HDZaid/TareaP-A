using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Contracts;
using PrimerProyectoPA;

namespace PrimerProyectoPA
{
    class Program
    {
        static void Main(string[] args)
        {
            //  List<Vehiculo> listaVehiculos = new List<Vehiculo>(30);

            int tamañoEstacionamiento = 30;
            int tamañoEstacionamientoMoto = 30;
            int tamañoEstacionamientoCamion = 30;
            List<Registro> listaRegistros = new List<Registro>(tamañoEstacionamiento);
            List<Registro> listaMoto = new List<Registro>(tamañoEstacionamientoMoto);
            List<Registro>listaCamion = new List<Registro>(tamañoEstacionamientoCamion);
            Registro registro = new Registro();
            int IdRegistro = 1;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ESTACIONAMIENTO");
            Console.ResetColor();
            bool continuar = true;
            do
            {

                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("#    [ 1 ]. Agregar Vehiculo                                     #");
                Console.WriteLine("#    [ 2 ]. Retirar Vehiculo                                     #");
                Console.WriteLine("#    [ 3 ]. Mostrar Vehiculos en estacionamiento                 #");
                Console.WriteLine("#    [ 4 ]. Mostrar Espacios Disponibles                         #");
                Console.WriteLine("#    [ 5 ]. Modificar Espacios                                   #");
                Console.WriteLine("#    [ 6 ]. Salir                                                #");
                Console.WriteLine("------------------------------------------------------------------");

                Console.WriteLine("Ingrese un número:");
                int opcion = Utilidades.LlenarNumeroEntero();
                
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("#    [ 1 ]. Agregar Carro                                        #");
                        Console.WriteLine("#    [ 2 ]. Agregar Moto                                         #");
                        Console.WriteLine("#    [ 3 ]. Agregar Camion                                       #");
                        Console.WriteLine("------------------------------------------------------------------");
                        opcion = Utilidades.LlenarNumeroEntero();
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Agregar Carro");
                                Carro carro = new Carro();
                                carro.AgregarVehiculo();
                                //listaVehiculos.Add(carro);
                                registro = new Registro(IdRegistro);
                                registro.CrearRegistro(carro);
                                listaRegistros.Add(registro);
                                IdRegistro++;
                                Utilidades.MensajeGris("-----------------> presiones cualquier tecla <-----------------");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("Agregar Moto");
                                Moto moto = new Moto();
                                moto.AgregarVehiculo();
                                //    listaVehiculos.Add(moto);
                                registro = new Registro(IdRegistro);
                                registro.CrearRegistro(moto);
                                listaMoto.Add(registro);
                                Utilidades.MensajeGris("-----------------> presiones cualquier tecla <-----------------");
                                Console.ReadKey();
                                IdRegistro++;
                                Console.Clear();
                                break;
                            case 3:
                                Console.WriteLine("agregar Camion");
                                Camion camion = new Camion();
                                camion.AgregarVehiculo();
                                registro = new Registro(IdRegistro);
                                registro.CrearRegistro(camion);
                                listaCamion.Add(registro);
                                Utilidades.MensajeGris("-----------------> presiones cualquier tecla <-----------------");
                                Console.ReadKey();
                                IdRegistro++;
                                Console.Clear();
                                break;
                            default:
                                
                                Console.WriteLine("No ha ingresado una opcion valida...");
                                Utilidades.MensajeGris("-----------------> presiones cualquier tecla <-----------------");
                                Console.ReadKey();
                                Console.Clear();
                                break;


                            }
                        Utilidades.MensajeGris("-----------------> presiones cualquier tecla <-----------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2: 
                        Console.WriteLine("RETIRAR VEHICULO");
                        Console.WriteLine("INGRESE EL NUMERO DE REGISTRO");
                        int registroBuscado = Convert.ToInt32(Console.ReadLine());
                        bool registroEncontrado = false;

                        foreach (Registro registro1 in listaRegistros)
                        {
                            if (registro1.IdRegistro == registroBuscado)
                            {
                                registro1.RetirarVehiculo(); 
                                Console.WriteLine("FACTURA:");
                                registro1.MostrarFactura();
                                listaRegistros.Remove(registro1);
                                registroEncontrado = true;
                                
                                break;
                            }

                        }
                        foreach (Registro registro1 in listaMoto)
                        {
                            if (registro1.IdRegistro == registroBuscado)
                            {
                                registro1.RetirarVehiculo();
                                Console.WriteLine("FACTURA:");
                                registro1.MostrarFactura();
                                listaMoto.Remove(registro1);
                                registroEncontrado = true;

                                break;
                            }

                        }

                        foreach (Registro registro1 in listaCamion)
                        {
                            if (registro1.IdRegistro == registroBuscado)
                            {
                                registro1.RetirarVehiculo();
                                Console.WriteLine("FACTURA:");
                                registro1.MostrarFactura();
                                listaCamion.Remove(registro1);
                                registroEncontrado = true;
                                break;
                            }

                        }
                        if (registroEncontrado==false)
                        {
                            Console.WriteLine("Registro no encontrado.");
                        }
                        Utilidades.MensajeGris("-----------------> presiones cualquier tecla <-----------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        bool registroBool = false;
                        Console.WriteLine("Mostrar Vehiculos");
                        foreach(Registro registro1 in listaRegistros)
                        {
                            registro1.MostrarVehiculoRegistrado();
                        }
                        foreach (Registro registro1 in listaMoto)
                        {
                            registro1.MostrarVehiculoRegistrado();
                        }
                        foreach (Registro registro1 in listaCamion)
                        {
                            registro1.MostrarVehiculoRegistrado();
                        }
                        if(registroBool == false)
                        {
                            Console.WriteLine("NO SE ENCONTRO NI MAUSER");
                        }
                        Utilidades.MensajeGris("-----------------> presiones cualquier tecla <-----------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Utilidades.MensajeRed("ESPACIOS EN EL ESTACIONAMIENTO DE CARROS");
                        Console.WriteLine("                      ----");
                        Console.WriteLine("ESPACIOS DISPONIBLES: |" +(tamañoEstacionamiento - listaRegistros.Count) + "|");
                        Console.WriteLine("                      ----");

                        Utilidades.MensajeBlue("ESPACIOS EN EL ESTACIONAMIENTO DE MOTOS");
                        Console.WriteLine("                      ----");
                        Console.WriteLine("ESPACIOS DISPONIBLES: |" + (tamañoEstacionamientoMoto - listaMoto.Count) + "|");
                        Console.WriteLine("                      ----");

                        Utilidades.Mensajeyellow("ESPACIOS EN EL ESTACIONAMIENTO DE CARROS");
                        Console.WriteLine("                      ----");
                        Console.WriteLine("ESPACIOS DISPONIBLES: |" + (tamañoEstacionamientoCamion - listaCamion.Count)+"|");
                        Console.WriteLine("                      ----");
                        Utilidades.MensajeGris("-----------------> presiones cualquier tecla <-----------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("#    [ 1 ]. ESPACIO CARROS                                       #");
                        Console.WriteLine("#    [ 2 ]. ESPACIO DE MOTOS                                     #");
                        Console.WriteLine("#    [ 3 ]. ESPACIO CAMIONES                                     #");
                        Console.WriteLine("------------------------------------------------------------------");
                        opcion = Utilidades.LlenarNumeroEntero();
                        switch (opcion)
                        {
                            case 1:
                                CambiarEspaciosListasCarros();
                                break; 
                            case 2:
                                CambiarEspaciosListasMotos();
                                break; 
                            case 3:
                                CambiarEspaciosListasCamiones();
                                break;
                        }

                        Utilidades.MensajeGris("-----------------> presiones cualquier tecla <-----------------");
                        Console.ReadKey();
                        Console.Clear();
                       
                        break;
                    case 6:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (continuar == true);

            void CambiarEspaciosListasMotos()
            {
                Utilidades.MensajeAzul("Ingresa la cantidad de Estacionamientos");
                tamañoEstacionamientoMoto = Utilidades.LlenarNumeroEntero();

            }

            void CambiarEspaciosListasCarros()
            {
                Utilidades.MensajeAzul("Ingresa la cantidad de Estacionamientos");
                tamañoEstacionamiento = Utilidades.LlenarNumeroEntero();

            }
            void CambiarEspaciosListasCamiones()
            {
                Utilidades.MensajeAzul("Ingresa la cantidad de Estacionamientos");
                tamañoEstacionamientoCamion = Utilidades.LlenarNumeroEntero();

            }

        }
    }
}
