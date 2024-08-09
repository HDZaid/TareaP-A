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
        public void MostrarInformacionHabitacionSimple() 
        {
            base.MostrarInformacion();
            Console.WriteLine($"El numero de camas en la habitacion es de:{NumeroCamas}");
        }
        public void pedirDatosHabitacionSimple() 
        {
            base.PedirInformacionDeHabitacion();
            Console.WriteLine("CUANTAS CAMAS HAY?");
            NumeroCamas = Convert.ToInt32(Console.ReadLine());
        }



    }
}

