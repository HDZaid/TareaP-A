using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Telefono: Electronico
    {
        public int Numero { get; set; }
        public int MegaPixelesCamara { get; set; }

        public void PedirDatosTelefono()
        {
            base.PedirDatos();
            Console.WriteLine("ingrese numero de telefono");
            Numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese los Megapixeles de la Camara");
            MegaPixelesCamara = Convert.ToInt32(Console.ReadLine());
        }
        public void MostrarDatosTelefono()
        {
            base.MostrarObjetos();
            Console.WriteLine($"Numero de telefono: {Numero}");
            Console.WriteLine($"Megapixeles de la camara: {MegaPixelesCamara}");
        }

    }
}
