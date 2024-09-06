using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoPA
{
    internal class Moto : Vehiculo
    {
        private string SideCar { get; set; }
        public Moto()
        {
        }

        public Moto(string placa, string marca, string color, string tipo, string modelo, string cliente) : base(placa, marca, color, tipo, modelo, cliente)
        {
        }
        
        public override void AgregarVehiculo()
        {
            base.AgregarVehiculo();
            Console.WriteLine("tiene side Car ? [ si ] [ no ] ");
            string palabra = Utilidades.LlenarString().ToLower();
            if (palabra == "si")
            {
                SideCar = "si";
            }
            else { SideCar = "no"; }
            
        }
        public override void MostrarVehiculos()
        {
            base.MostrarVehiculos();
            Console.WriteLine("tiene side car: "+SideCar);
            Console.WriteLine("---------------------------------------");
        }
    }
}
