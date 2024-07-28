using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("CALCULADORA ESTADISTICA");
        CalculadoraEstadistica calculadora = new CalculadoraEstadistica();
        calculadora.Menu();
    }
}

class DatosEstadisticos
{
    public List<int> Numeros { get; set; }

    public DatosEstadisticos()
    {
        Numeros = new List<int>();
    }
}

class CalculadoraEstadistica
{
    private DatosEstadisticos datos;

    public CalculadoraEstadistica()
    {
        datos = new DatosEstadisticos();
    }

    public void Menu()
    {
        bool repetirMenu = true;
        while (repetirMenu)
        {
            Console.WriteLine("BIENVENIDO INGRESE UN NUMERO");
            Console.WriteLine("[ 1 ] ---> INGRESAR NUMEROS");
            Console.WriteLine("[ 2 ] ---> MEDIANA");
            Console.WriteLine("[ 3 ] ---> MEDIA");
            Console.WriteLine("[ 4 ] ---> MODA");
            Console.WriteLine("[ 5 ] ---> DESVIACION ESTANDAR");
            Console.WriteLine("[ 6 ] ---> SALIR");

            int opcionMenu = Convert.ToInt32(Console.ReadLine());
            switch (opcionMenu)
            {
                case 1:
                    datos.Numeros = CrearLista();
                    ImprimirLista(datos.Numeros);
                    break;
                case 2:
                    CalcularMediana(datos.Numeros);
                    break;
                case 3:
                    CalcularMedia(datos.Numeros);
                    break;
                case 4:
                    try
                    {
                        Moda(datos.Numeros);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("SI NO FUNCIONA ES PORQUE TIENE QUE AÑADIR MAS VALORES IGUALES, ej.:2,2,2 o similar");
                    }
                    break;
                case 5:
                    CalcularDesviacionEstandar(datos.Numeros);
                    break;
                case 6:
                    Console.WriteLine("HA SALIDO DEL MENU ADIOS ");
                    repetirMenu = false;
                    break;
            }
        }
    }

    private List<int> CrearLista()
    {
        List<int> nuevaLista = new List<int>();
        int numero;
        Console.WriteLine("Ingrese los números (ingrese 0 para terminar):");

        while (true)
        {
            try
            {
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 0) break;
                nuevaLista.Add(numero);
            }
            catch (Exception)
            {
                Console.WriteLine("El valor ingresado es equivocado, intentelo de nuevo");
            }
        }
        nuevaLista.Sort();
        return nuevaLista;
    }

    private void ImprimirLista(List<int> lista)
    {
        foreach (var valor in lista)
        {
            Console.WriteLine("valores: " + valor);
        }
        Console.WriteLine("TOTAL DE DATOS: " + lista.Count);
    }

    private void CalcularMediana(List<int> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("No hay datos para calcular la mediana.");
            return;
        }

        double mediana;
        int puntoMedio = lista.Count / 2;

        if (lista.Count % 2 == 0)
        {
            mediana = (lista[puntoMedio - 1] + lista[puntoMedio]) / 2.0;
        }
        else
        {
            mediana = lista[puntoMedio];
        }

        Console.WriteLine("La mediana es: " + mediana);
    }

    private void CalcularMedia(List<int> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("No hay datos para calcular la media.");
            return;
        }

        double media = lista.Average();
        Console.WriteLine("La media es: " + media);
    }

    private void CalcularDesviacionEstandar(List<int> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("No hay datos para calcular la desviación estándar.");
            return;
        }

        double media = lista.Average();
        double sumaDesviaciones = lista.Sum(num => Math.Pow(num - media, 2));
        double varianza = sumaDesviaciones / lista.Count;
        double desviacionEstandar = Math.Sqrt(varianza);

        Console.WriteLine("La desviación estándar es: " + desviacionEstandar);
    }

    private void Moda(List<int> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("No hay datos para calcular la moda.");
            return;
        }

        var grupos = lista.GroupBy(x => x).OrderByDescending(g => g.Count());
        int modaValor = grupos.First().Key;
        Console.WriteLine("La moda es: " + modaValor);
    }
}