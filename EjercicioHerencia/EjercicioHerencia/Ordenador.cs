using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Ordenador: Electronico
    {
        public string Grafica { get; set; }
        public bool RGB { get; set; }

        public void MostrarDatosOrdenador()
        {
            base.MostrarObjetos();
            Console.WriteLine($"targeta grafica:{Grafica}");
            Console.WriteLine($"Tiene RGB  (RGB = +FPS): {RGB}");
        }

        public void PedirDatosOrdenador()
        {
            base.PedirDatos();
            Console.WriteLine("TIPO DE TARGETA:");
            Grafica = Console.ReadLine();
            Console.WriteLine("RGB:");
            string luces = ""; 
            luces = Console.ReadLine().ToLower();
            RGB = (luces == "n" || luces == "no");
        }
        
    }
}
