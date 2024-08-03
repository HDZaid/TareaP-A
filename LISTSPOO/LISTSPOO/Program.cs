using POOyListasBiblioteca;

class Program
{
    static void Menu()
    {
        Libro Biblioteca = new Libro();
        do
        {
            Console.WriteLine("Opciones");
            Console.WriteLine("1. Mostrar Libros");
            Console.WriteLine("2. Agregar Libros");
            Console.WriteLine("3. Eliminar Libro");
            Console.WriteLine("4. Buscar Libro");
            Console.WriteLine("5. cambiar Libro");
            Console.WriteLine("6. Salir");

            Console.Write("Ingrese el número de la opción que desea realizar: ");
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 8)
            {
                Console.WriteLine("Opción no válida. Ingrese un número del 1 al 8.");
                Console.Write("Ingrese el número de la opción que desea realizar: ");
            }

            switch (opcion)
            {
                case 1:
                    Biblioteca.MostrarLibros();
                    Biblioteca.LimpiarConsola();
                    break;
                case 2:
                    Biblioteca.AgregarLibro();
                    Biblioteca.LimpiarConsola();
                    break;
                case 3:
                    Biblioteca.EliminarLibro();
                    Biblioteca.LimpiarConsola();
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nombre del libro: ");
                    string nombre = Console.ReadLine();
                    Biblioteca.BuscarLibro(nombre);
                    Biblioteca.LimpiarConsola();
                    break;
                case 5:
                    Biblioteca.EditarLibro();
                    Biblioteca.LimpiarConsola();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("Programa terminado. ¡Gracias!");
                    Environment.Exit(0);
                    break;
            }



        } while (true);
    }
    static void Main(string[] args)
    {
        Menu();
    }
}