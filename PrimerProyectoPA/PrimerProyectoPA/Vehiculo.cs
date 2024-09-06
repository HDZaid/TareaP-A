using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoPA
{
    internal class Vehiculo
    {
        private string Placa { get; set; }
        private string Marca { get; set; }
        private string Color { get; set; }
        private string Tipo { get; set; }
        private string Modelo { get; set; }
        private string Cliente { get; set; }

        public Vehiculo(string placa, string marca, string color, string tipo, string modelo, string cliente)
        {
            this.Placa = placa;
            this.Marca = marca;
            this.Color = color;
            this.Tipo = tipo;
            this.Modelo = modelo;
            this.Cliente = cliente;
        }
        public Vehiculo()
        {
            
        }
        public virtual void AgregarVehiculo()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("ingrese la marca: ");
            this.Marca = Utilidades.LlenarString().ToLower();
            Console.WriteLine("Ingrese la Placa: ");
            this.Placa = Utilidades.LlenarString().ToUpper();
            Console.WriteLine("Ingrese el color: ");
            this.Color = Utilidades.LlenarString().ToLower();
            Console.WriteLine("Ingrese el modelo");
            this.Modelo = Utilidades.LlenarString().ToLower();
            Console.WriteLine("Ingrese el nombre del Cliente: ");
            this.Cliente = Utilidades.LlenarString().ToUpper();
            Console.WriteLine("-----------------------------------");
        }

        public virtual void MostrarVehiculos () 
        {
            //Console.WriteLine($"El cliente es: {Cliente}");
            Console.WriteLine($"Tiene un auto: {Marca}");
            Console.WriteLine($"Con placas: {Placa}");
            Console.WriteLine($"De color:{Color}");
            Console.WriteLine($"Es Modelo:{Modelo}");
        }

        public virtual void DatosPropietario()
        {
            Console.WriteLine($"EL PROPIETARIO ES: [{Cliente}]");
        }

    }
}
