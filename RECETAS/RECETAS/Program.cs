using RECETAS;

Console.WriteLine("RECETARIO");

bool repetirMenu = true;
int opcionSwitch = 0;
Receta LibroRecetas = new Receta();
while (repetirMenu)
{
    MostrarMenu();
    opcionSwitch=Convert.ToInt32(Console.ReadLine());
    switch (opcionSwitch)
    {
        case 2:
            
            string nombre = "";
            int numero = 0;
            string descripcion = "";
            Console.WriteLine("AGREGAR RECETA");
            Console.WriteLine("NOMBRE");
            nombre =Console.ReadLine();
            Console.WriteLine("NUMERO DE LA RECETA");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DESCRIPCION");
            descripcion = Console.ReadLine();
            LibroRecetas.AgregarReceta(nombre, numero,descripcion);
            break;

        case 3:
            Console.WriteLine("BUSCAR RECETA");
            LibroRecetas.MostrarRecetaBuscada(LibroRecetas.BuscarReceta());
            break;

        case 4:
            Console.WriteLine("MOSTRAR RECETA");
            LibroRecetas.MostrarReceta();
            break; 
        
        case 7:
            Console.WriteLine("SALIR");
            break;
    }
}

static void MostrarMenu()
{
    Console.WriteLine("[ 2 ] Agregar receta");
    Console.WriteLine("[ 3 ] BUSCAR receta");
    Console.WriteLine("[ 4 ] mostrar receta");
    Console.WriteLine("[ 7 ] SALIR");
}

