using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int CantidadEnStock { get; set; }

        public Producto(string nombre, double precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            CantidadEnStock = cantidad;
        }

    }

