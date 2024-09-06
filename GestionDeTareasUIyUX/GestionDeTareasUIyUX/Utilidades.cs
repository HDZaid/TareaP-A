using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeTareasUIyUX
{
    internal class Utilidades
    {
        public static void TituloMensaje(string contenidoTitulo)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(contenidoTitulo);
            Console.ResetColor();
        }
        public static void MensajeAmarillo(string contenidoTitulo)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(contenidoTitulo);
            Console.ResetColor();
        }
        public static void ErrorMensaje(string contenidoTitulo)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(contenidoTitulo);
            Console.ResetColor();
        }
        public static void MensajeAzul(string contenidoTitulo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(contenidoTitulo);
            Console.ResetColor();
        }
        public static void MensajeMorado(string contenidoTitulo)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(contenidoTitulo);
            Console.ResetColor();
        }
        public static void MensajeVerde(string contenidoTitulo)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(contenidoTitulo);
            Console.ResetColor();
        }
        public static string LlenarString()
        {
            string cadena = string.Empty;
            bool valido = false;
            while (!valido)
            {
                cadena = Console.ReadLine();
                if (!string.IsNullOrEmpty(cadena))
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("[!] No puede ingresar datos vacíos...");
                    Console.Write("Intente de nuevo: ");
                }
            }
            return cadena;
        }
        public static int LlenarNumeroEntero()
        {
            int numeroEntero = 0;
            bool valido = false;
            while (!valido)
            {
                try
                {
                    while (numeroEntero <= 0)
                    {
                        numeroEntero = Convert.ToInt32(Console.ReadLine());
                        if (numeroEntero <= 0)
                        {
                            Console.Write("[!] No puede ingresar numeros negativos...\nIntente de nuevo: ");
                        }
                        valido = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("[!] Error no puede ingresar letras...");
                    Console.Write("> Intente de nuevo: ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[!] Error desconocido... " + ex);
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return numeroEntero;
        }

        public static void EsperaConfirmacion()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\tPresione 'Enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

    }
}
