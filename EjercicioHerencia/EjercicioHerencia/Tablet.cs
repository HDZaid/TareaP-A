using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Tablet: Electronico
    {
        public bool Lapiz { get; set; }
       
        public void MostrarDatosTablet()
        {
            base.MostrarObjetos();
            Console.WriteLine($"tiene lapiz :{Lapiz}");
        }
        public void PedirDatosTablet()
        {
            base.PedirDatos();
            Console.WriteLine($"Trae lapiz?");
            string traeVaina=Console.ReadLine();
            Lapiz= (traeVaina == "n" || traeVaina == "no");
        }
    }
}
