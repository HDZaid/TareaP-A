using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    internal class Habitacion
    {
        public int NumeroHabitacion { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponible { get; set; }
        public string NombreCliente { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Numero de Habitacion: {NumeroHabitacion}");
            Console.WriteLine($"Precio de Habitacion: {PrecioPorNoche}");
            Console.WriteLine($"Habitacion Disponible: {Disponible}");
            if (Disponible = true)
            {
                Console.WriteLine($"Numero de Habitacion: {NombreCliente}");
            }
        }
        public void PedirInformacionDeHabitacion()
        {
            Console.WriteLine("NUMERO DE HABITACION");
            NumeroHabitacion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PRECIO POR NOCHE");
            PrecioPorNoche = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("LA HABITACION ESTA DISPOIBLE");
            Disponible = true;
        }

        public void MostraDisponibilidad()
        {
            if (Disponible = true)
            {
                Console.WriteLine("LA HABITACION ESTA DISPOBIBLE");
            }
            else
            {
                Console.WriteLine("la habitacion NO esta disponible");
            }
        }

        public void AsignarCliente()
        {
            Console.WriteLine("NOMBRE DEL CLIENTE");
            NombreCliente = Console.ReadLine();
            Disponible = false;
        }
        public void LiberarAsignacion()
        {
            Console.WriteLine("");
            Disponible = true;
        }

    }
}
