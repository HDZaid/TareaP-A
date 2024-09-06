using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoPA
{
    internal class PagoConTarjeta : Pago
    {

        public double SaldoBancario { get; set; }
        private string NumeroDeTargeta { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int CCV { get; set; }

        public PagoConTarjeta()
        {
            SaldoBancario = 300;
            NumeroDeTargeta = "123 456 789";
            NombreCompleto = "jose moises granados guevara";
            FechaVencimiento = new DateTime(2020, 08, 10);
            CCV = 123;
        }

        public override void RealizarPago(double tarifa)
        {
            Console.WriteLine("Ingrese los datos de la tarjeta:");
            int intentos = 5;
            while (intentos > 0 )
            {
                Console.Write("NUMERO DE CUENTA: ");
                string NumeroCuenta = Utilidades.LlenarString();
                if (NumeroCuenta == NumeroDeTargeta)
                {
                    intentos = 5;
                    while (intentos > 0)
                    {
                        Console.Write("NOMBRE COMPLETO:");
                        string nombre = Utilidades.LlenarString();
                        if (nombre == NombreCompleto)
                        {
                            intentos = 5;
                            while (intentos > 0)
                            {
                                Console.Write("CCV:");
                                int ccv = Utilidades.LlenarNumeroEntero();  
                                if(ccv == CCV)
                                {
                                    Console.WriteLine("TODOS LOS DATOS SON CORRECTOS");
                                    if (SaldoBancario > tarifa)
                                    {
                                        SaldoBancario = SaldoBancario - tarifa;
                                        intentos= 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("no tienes pisto suficiente pa pagar we");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("DATOS INCORRECTOS INGRESALO NUEVAMENTE");
                                    intentos--;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("DATOS INCORRECTOS INGRESALO NUEVAMENTE");
                            intentos--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("DATOS INCORRECTOS INGRESALO NUEVAMENTE");
                    intentos--;
                }
            }
            
        }

        public override void EmitirFactura()
        {
            base.EmitirFactura();
            Console.WriteLine($"EL NUEVO SALDO DE SU CUENTA ES: {SaldoBancario}");
        }
    }
}
