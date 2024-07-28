using CalculadoraEstadisticaPOO;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    static List<double> ListaNumeros = new List<double>();
    static int numeroEntero;
    static double numero;
    static double resultado;
    public static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();
        int opcion;
        do
        {
            ImprimirMenu();
            switch (opcion = LlenarNumeroEntero())
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("[1]..... Ingresar numeros a la lista");
                    LlenarLista();
                    ImprimirLista();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("[2] Calcular la media");
                    ImprimirLista();
                    resultado = calculadora.Media(ListaNumeros);
                    Console.WriteLine("El resultado de la media es: " + resultado);
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("[3] Calcular la mediana");
                    ImprimirLista();
                    resultado = calculadora.Mediana(ListaNumeros);
                    Console.WriteLine("La mediana para la lista es: " + resultado);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("[4] Calcular la moda");
                    ImprimirLista();
                    calculadora.Moda(ListaNumeros);
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("[5] Calcular la desviacion estandar");
                    ImprimirLista();
                    calculadora.DesviacionEstandar(ListaNumeros);
                    Console.WriteLine("La desviacion estandar es: " + resultado);
                    Console.WriteLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("[!] Opcion Invalida");
                    break;
            }

        } while (opcion != 6);
        Console.WriteLine("Justo Geovanny Alcon Mendoza, 1578324");
        Console.ReadLine();
    }
    static void ImprimirMenu()
    {
        Console.WriteLine("Calculadora Estadistica");
        Console.WriteLine("[1] Ingresar numeros a la lista");
        Console.WriteLine("[2] Calcular la media");
        Console.WriteLine("[3] Calcular la mediana");
        Console.WriteLine("[4] Calcular la moda");
        Console.WriteLine("[5] Calcular la desviacion estandar");
        Console.WriteLine("[6] Finalizar programa");
        Console.Write("Ingrese una opcion: ");
    }
    static void ImprimirLista()
    {
        Console.WriteLine("Lista de numeros: ");
        Console.Write("\t[  ");
        foreach (var i in ListaNumeros)
        {
            Console.Write(i + "  ");
        }
        Console.Write("]\n\n");
    }
    static void LlenarLista()
    {
        ListaNumeros.Clear();
        Console.Write("Ingrese el tamaño de los datos que desea llenar: ");
        int tamaño = LlenarNumeroEntero();
        for (int i = 0; i < tamaño; i++)
        {
            Console.Write($"Ingrese el numero en la posicion ({i + 1}): ");
            ListaNumeros.Add(LlenarNumero());
        }
        Console.WriteLine();
    }
    static double LlenarNumero()
    {//Llenar numero
        bool valido = false;
        while (!valido)
        {
            try
            {
                numero = Convert.ToDouble(Console.ReadLine());
                //se ejecuta linea por linea si hay una excepcion se captura antes del bool
                valido = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("[!] Error no puede ingresar letras...");
                Console.Write("Intente de nuevo: ");
            }
            catch (Exception)
            {
                Console.WriteLine("[!] Error desconocido... ");
                Console.Write("> Intente de nuevo: ");
            }
        }
        return numero;
    }
    static int LlenarNumeroEntero()
    {//Llenar numero
        bool valido = false;
        while (!valido)
        {
            try
            {
                numeroEntero = Convert.ToInt32(Console.ReadLine());
                //se ejecuta linea por linea si hay una excepcion se captura antes del bool
                valido = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("[!] Error no puede ingresar letras...");
                Console.Write("Intente de nuevo: ");
            }
            catch (Exception)
            {
                Console.WriteLine("[!] Error desconocido... ");
                Console.Write("> Intente de nuevo: ");
            }
        }
        return numeroEntero;
    }

}