using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoPA
{
    internal class Carro : Vehiculo
    {
        public string Estilo { get; set; }
        public Carro(string placa, string marca, string color, string tipo, string modelo, string cliente, string estilo) : base(placa, marca, color, tipo, modelo, cliente)
        {
            this.Estilo = estilo; 
        }
        public Carro()
        {
        }

        public override void AgregarVehiculo()
        {
            Console.WriteLine("Que estilo tiene ?");
            Console.WriteLine("[deportivo] [sedan] [camioneta] [hatchback]");
            this.Estilo = Utilidades.LlenarString();
            base.AgregarVehiculo();
        }
        public override void MostrarVehiculos()
        {
            base.MostrarVehiculos();
            Console.WriteLine($"tipo de carro:{Estilo}");

            Console.WriteLine("-----------------------------------");

        }

    }
}
