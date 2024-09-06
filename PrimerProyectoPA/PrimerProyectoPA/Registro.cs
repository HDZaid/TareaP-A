using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoPA
{
    internal class Registro
    {
        public int IdRegistro { get; set; }
        public Vehiculo Vehiculo { get; set; }     
        public Pago Pago { get; set; }
        public bool Estacionado { get; set; }
        public DateTime TiempoEntrada { get; set; }
        public double Tarifa { get; set; }

        public Registro(int idRegistro = 0) 
        {

            this.IdRegistro = idRegistro;
        }

        public void CrearRegistro(Vehiculo vehiculo)
        {
            
            Vehiculo = vehiculo;
            Estacionado = true;
            TiempoEntrada = DateTime.Now;
            Console.WriteLine("                ---");
            Console.WriteLine($"el registro es:[ {IdRegistro} ] ");
            Console.WriteLine("                ---");
            Console.WriteLine($"hor de llegd:{TiempoEntrada}");
        }
        public void RetirarVehiculo()
        {
            Estacionado = false;
            Console.WriteLine("");
            Console.WriteLine($"-------------------------------------------------------------------------------------");
            Console.WriteLine($"  |ID del registro: [ {IdRegistro} ]                                                  ");
            Tarifa = CalcularTarifa();
            Console.WriteLine($"  |tarifa por curbir: [ {Tarifa} ]                                                ");
            Console.WriteLine($"  |forma de pago: [ 1 ] efectivo, [ 2 ] tarjeta                                     ");
            Console.WriteLine($"-------------------------------------------------------------------------------------");
            Console.WriteLine("");

            int opcionMenu = Utilidades.LlenarNumeroEntero();
            switch (opcionMenu)
            {
                case 1:
                    Console.WriteLine("pago con efectivo");
                    this.Pago = new PagoEnEfectivo();
                    Pago.RealizarPago(Tarifa);
                    break;

                case 2:
                    Console.WriteLine("pago con tarjeta");
                    this.Pago = new PagoConTarjeta();
                    Pago.RealizarPago(Tarifa);
                    break;
            }
        }
        public double CalcularTarifa()
        {
            DateTime horaActual = DateTime.Now;

            TimeSpan tiempoEstacionado = horaActual - TiempoEntrada;

            double horas = tiempoEstacionado.TotalHours;
           
            Console.WriteLine($"  |El Tiempo que ha estado estacionado es de: {tiempoEstacionado.Hours} horas, {tiempoEstacionado.Minutes} minutos y {tiempoEstacionado.Seconds} segundos|");
            int horasRedondeadas = (int)Math.Ceiling(horas);
            int tarifaPorHora = 5;
            int minimoHorasACobrar = 1;

            horasRedondeadas = Math.Max(horasRedondeadas, minimoHorasACobrar);

            return horasRedondeadas * tarifaPorHora;
        }
        public void MostrarVehiculoRegistrado()
        {
            Console.WriteLine("********************************************");
            Vehiculo.MostrarVehiculos();
            Console.WriteLine("********************************************");
        }
        public void MostrarFactura()
        {
            
            Pago.EmitirFactura();
            Console.WriteLine("Datos de propietario ");
            Vehiculo.DatosPropietario();
            Console.WriteLine("datos del auto:");
            Vehiculo.MostrarVehiculos();
            
        }
    }
}
