using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    internal class Doble : Habitacion
    {
        public bool VistaAlMar { get; set; }
        public void MetodoVistaAlMar()
        {
            base.MostraDisponibilidad(); //cambiar metodo
            Console.WriteLine("TIENE VISTA AL MAR?");
            string coso = Console.ReadLine().ToLower();
            if (coso == "s" && coso == "si")
            {
                VistaAlMar = true;

            } else
            {
                VistaAlMar = false;
            }
        }
    }
}
