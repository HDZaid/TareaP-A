using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimerProyectoPA
{
    public class Pago
    {
        public int NumeroDeFactura { get; set; }
      //  public Vehiculo Vehiculo { get; set; }

        public Pago(int numeroFactura )
        {
            Random random = new Random();
            numeroFactura = random.Next(10000);
            NumeroDeFactura = numeroFactura;
            
        }
        public Pago()
        {
            
        }

        public virtual void RealizarPago(double tarifa)
        {
            Console.WriteLine($"La tarifa a pagar es: {tarifa}");
        }

        public virtual void EmitirFactura()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"|No. Factura : STR00{NumeroDeFactura}               |");
            Console.WriteLine("--------------------------------------");
            

        }
    }
}
