using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeTareasUIyUX
{
    internal class Tarea
    {
        public string NombreTarea { get; set; }
        public string Descripccion { get; set; }
        public string Descripccion1 { get; set; }
        public int NumeroTarea { get; set; }
        public bool EstadoTarea { get; set; }

        public Tarea(string nombreTarea, string descripccion,string descripcion1, int numeroTarea, bool estadoTarea)
        {
            NombreTarea = nombreTarea;
            Descripccion = descripccion;
            Descripccion1 = descripcion1;
            NumeroTarea = numeroTarea;
            EstadoTarea = estadoTarea;
        }

        public Tarea()
        {
        }

        public void CrearTarea()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("ingrese el nombre de la tarea");
            NombreTarea = Console.ReadLine();
            Console.WriteLine("ingrese una descripcion:");
            Descripccion = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------");
            EstadoTarea = false;
            NumeroTarea++;
        }
        public void MarcarTareaCompletada()
        {
            EstadoTarea = true;
        }

        public void MostrarTareasTodasLasTareas()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("                         ─────");
            Console.WriteLine($"Numero de la Tarea:      │ {NumeroTarea} │");
            Console.WriteLine("                         ─────");
            Console.WriteLine("------------------------------");
            Utilidades.MensajeAmarillo($"{NombreTarea}");
            if (EstadoTarea == false)
            {
                Utilidades.ErrorMensaje("      |Estado|: [X]");
            }
            else
            {
                Utilidades.MensajeVerde("      |Estado|: [;)]");
            }
            
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{Descripccion}");
            Console.WriteLine($"{Descripccion1}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

        }



    }
}
