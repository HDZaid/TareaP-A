using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PrimerProyectoPA
{
    public class PagoEnEfectivo : Pago
    {
        public int Cuenta { get; set; }
        public PagoEnEfectivo()
        {
        }

        

        public override void RealizarPago(double tarifa)
        {

            Console.WriteLine("Ingrese el efectivo:");
            int efectivoIngresado = Utilidades.ingresarBilletes();

            if (efectivoIngresado >= tarifa)
            {
                int vuelto = efectivoIngresado - (int)tarifa;
                Cuenta = vuelto;
                Console.WriteLine("Pago realizado con éxito. Su vuelto es: " + vuelto);

                int[] denominaciones = { 200, 100, 50, 20, 10, 5, 1 };

                Console.WriteLine("Vuelto en billetes:");

                foreach (int denominacion in denominaciones)
                {
                    int cantidadBilletes = vuelto / denominacion;
                    vuelto %= denominacion;

                    if (cantidadBilletes > 0)
                    {
                        Console.WriteLine($"El vuelto es : {vuelto} que se dara en:");
                        Console.WriteLine($"{cantidadBilletes} Billetes de {denominacion}: ");

                    }
                }
            }
            else
            {
                Console.WriteLine("Pago insuficiente.");
            }
        }
        public override void EmitirFactura()
        {
            
            base.EmitirFactura();
            Console.WriteLine($"TOTAL:            {Cuenta}");
        }
    }
}
