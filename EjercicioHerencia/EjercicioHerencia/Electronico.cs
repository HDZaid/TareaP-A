using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Electronico
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int TamañoPantalla { get; set; }

        public void MostrarObjetos()
        {
            Console.WriteLine($"nombre: {Nombre.ToUpper()}");
            Console.WriteLine($"marca: {Marca.ToUpper()}");
            Console.WriteLine($"tamaño de pantalla:{TamañoPantalla}");

        }

        public void PedirDatos()
        {
            Console.WriteLine("INGRESA EL NOMBRE:");
            Nombre = Console.ReadLine();
            Console.WriteLine("INGRESA LA MARCA:");
            Marca = Console.ReadLine();
            Console.WriteLine("INGRESA EL TAMAÑO DE LA PANTALLA:");
            TamañoPantalla = Convert.ToInt32(Console.ReadLine());
        }


        /*
        void CargarElectroinico()
        {
            Console.WriteLine("El dispositivo esta cargando...");
        }
        void EncenderElectronico()
        {
            Console.WriteLine("SE ENCENDIO");
        }
        void ApagarElectronico() 
        {
            Console.WriteLine("SE APAGO");
        }
        */
    }
}
