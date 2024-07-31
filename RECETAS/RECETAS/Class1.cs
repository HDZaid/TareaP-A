using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECETAS
{
    internal class Receta
    {
        public List<string> Nombre { get; set; }
        public List<int> Numero { get; set; }
        public List<string> Ingredientes { get; set; }

        public Receta()
        {
            Nombre = new List<string>();
            Numero = new List<int>();
            this.Ingredientes = new List<string>();
        }

        public void AgregarReceta(String nombre, int numero, String ingredientes)
        {
            Nombre.Add(nombre);
            Numero.Add(numero);
            Ingredientes.Add(ingredientes);
            Console.WriteLine("LISTO AGREGADO");
        }
        public void MostrarReceta()
        {
            Console.WriteLine("LA LISTA DE RECETAS ES:");
            for(int i = 0; i < Nombre.Count; i++)
            {
                Console.WriteLine($"\t\t{Nombre[i]}");
                Console.WriteLine($"\t\t{Numero[i]}");
                Console.WriteLine($"\t\t {Ingredientes[i]}");
            }
        }
        public int BuscarReceta()
        {
            string nombreBuscar = "";
            Console.WriteLine("INGRESE EL NOMBRE DE LA RECETA QUE BUSCA");
            nombreBuscar = Console.ReadLine();

            for (int i = 0; i < Nombre.Count; i++) 
            {
                if (Nombre[i] == nombreBuscar)
                {
                    return i;
                    
                }

            }
            return -1;
        }

        public void MostrarRecetaBuscada(int posicion)
        {
            Console.WriteLine("LA RECETA ES:");
            Console.WriteLine($"{Nombre[posicion]}");
            Console.WriteLine($"{Numero[posicion]}");
            Console.WriteLine($"{Ingredientes[posicion]}");
        }
    }
    

}
