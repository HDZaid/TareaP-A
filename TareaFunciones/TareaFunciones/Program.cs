
using System;
Console.WriteLine("CALCULADORA ESTADISTICA");
List<int> NuevaLista = new List<int>();
menu();

void menu()
{
    bool repetirMenu = true;
    while (repetirMenu == true)
    {
        int opcionMenu = 0;
        Console.WriteLine("BIENVENIDO INGRESE UN NUMERO");
        Console.WriteLine("[ 1 ] ---> INGRESAR NUMEROS");
        Console.WriteLine("[ 2 ] ---> MEDIANA");
        Console.WriteLine("[ 3 ] ---> MEDIA");
        Console.WriteLine("[ 4 ] ---> MODA");
        Console.WriteLine("[ 5 ] ---> DESVIACION ESTANDAR");
        Console.WriteLine("[ 6 ] ---> SALIR");
        opcionMenu = Convert.ToInt32(Convert.ToInt32(Console.ReadLine()));

        switch (opcionMenu)
        {
            case 1:
                NuevaLista = CrearLista();
                ImprimirLista(NuevaLista);
                break;

            case 2:
                Console.WriteLine("CALCULAR LA MEDIANA");
                Console.WriteLine("La mediana se puede calcular poniendo los números en orden ascendente y ");
                Console.WriteLine("luego localizando el número del centro de esa distribución.");
                CalcularMediana(NuevaLista);
                break;

            case 3:
                Console.WriteLine("CALCULAR LA MEDIA");
                Console.WriteLine("sumando todos los valores y dividiendo la suma ");
                Console.WriteLine("entre el número total de valores; obtenemos la media");
                CalcularMedia(NuevaLista);
                break;

            case 4:
                try
                {
                    Console.WriteLine("CALCULAR LA MODA");
                    Moda(NuevaLista);
                }catch(Exception ex)
                {
                    Console.WriteLine("SI NO FUNCIONA ES PORQUE TIENE QUE AÑADIR MAS VALORES IGUALES, ej.:2,2,2 o similar ");
                }
                break;

            case 5:
                Console.WriteLine("CALCULAR LA DESVIACION ESTANDAR");
                Console.WriteLine("'S' ES LA DESVIACION ESTANDAR que se calcula");
                Console.WriteLine("S = raiz cuadrada de la suma de los valores menos su promedio al cuadrado");
                Console.WriteLine("partido el total de datos menos una unidad");
                CalcularDesviacionEstandar(NuevaLista);
                break;

            case 6:
                Console.WriteLine("HA SALIDO DEL MENU ADIOS ");
                repetirMenu = false;
                break;
        }
    }
}

static List<int> CrearLista()
{

    List<int> NuevaLista = new List<int>();
    int numero = 0;
    bool opcion = true;
    while (opcion == true)
    {
        try
        {
            Console.WriteLine("Ingrese los números (ingrese 0 para terminar):");

            while (true)
            {
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 0)
                {
                    opcion = false;
                    break;
                }
                NuevaLista.Add(numero);
            }
            NuevaLista.Sort();

        }
        catch (Exception ex)
        { Console.WriteLine("el valor ingresado es equivocado intentelo de nuevo"); }
    }
    return NuevaLista;
}

static void ImprimirLista(List<int> lista)
{
    for (int i = 0; i < lista.Count; i++)
    {
        Console.WriteLine("valores:" + lista[i]);
    }
    Console.WriteLine("TOTAL DE DATOS:" + lista.Count());
}

static void CalcularMediana(List<int> lista)
{
    int sumaMediana = 0;
    int elementosLista = lista.Count();
    double mediana = sumaMediana / elementosLista;
    int puntoMedio = lista.Count() / 2;
    if (elementosLista % 2 == 0)
    {
        double medianaLista = (lista[puntoMedio] + lista[puntoMedio ] / 2);
        Console.WriteLine("la mediana es NUEVA:" + medianaLista);
    }
    else
    {
        Console.WriteLine("la mediana es:" + mediana);
    }
}

static void CalcularMedia(List<int> lista)
{
    int sumaMedia = 0;
    int elementosLista = lista.Count();

    for (int i = 0; i < elementosLista; i++)
    {
        sumaMedia += lista[i];
    }

    double media = sumaMedia / lista.Count();

    Console.WriteLine("La media es: " + media);
}

static void CalcularDesviacionEstandar(List<int> lista)
{
    int sumaMedia = 0;
    double resultadoRaiz = 0;
    int elementosLista = lista.Count();

    for (int i = 0; i < elementosLista; i++)
    {
        sumaMedia += lista[i];
    }

    double media = sumaMedia / lista.Count();
    //
    double sumaDesviaciones = 0;
    foreach (int i in lista)
    {
        double diferencia = i - media;
        sumaDesviaciones += Math.Pow(diferencia, 2);
    }
    double varianza = (sumaDesviaciones / lista.Count);
    resultadoRaiz = (Math.Sqrt(varianza));
    Console.WriteLine("LA VARIANZA ES:" + varianza);

}

static void Moda(List<int> lista)
{
    int[] conteo = new int[lista.Count()+1];
    foreach (int num in lista)
    {
        conteo[num]++;
    }

    int modaIndice = conteo.ToList().IndexOf(conteo.Max());
    int modaValor = modaIndice;

    Console.WriteLine("La moda es: " + modaValor);
}