using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoPA
{
    internal class Camion : Vehiculo
    {
        private string Cabezal { get; set; }

        public Camion() { }
        public override void AgregarVehiculo()
        {
            base.AgregarVehiculo();
            Console.WriteLine("trae cabezal ? [ si ] [ no ] ");
            string palabra = Utilidades.LlenarString().ToLower();
            if (palabra == "si")
            {
                Cabezal = "si";
            }
            else { Cabezal = "no"; }
        }
        public override void MostrarVehiculos()
        {
            base.MostrarVehiculos();
            Console.WriteLine("el camion trae cabezal? "+ Cabezal);
            Console.WriteLine("-----------------------------------");
        }
    }
}
