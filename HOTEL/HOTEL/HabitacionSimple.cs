using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    internal class HabitacionSimple : Habitacion
    {
        public int NumeroCamas { get; set; }
        public void ModificarNumeroCamas() 
        {
            base.MostrarInformacion();
            Console.WriteLine("");
        }
        public void pedirNumeroCamas() 
        {
            Console.WriteLine("CUANTAS CAMAS HAY?");
            NumeroCamas = Convert.ToInt32(Console.ReadLine());
        }

    }
}
