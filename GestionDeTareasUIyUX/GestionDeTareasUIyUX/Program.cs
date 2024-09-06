using GestionDeTareasUIyUX;
using System.Threading;

Console.WriteLine("BIENVENIDO AL GESTOR DE TAREAS");
int opcionMenu = 0;
bool opcionWhile=true;
//Tarea tarea = new Tarea();
List<Tarea> listaTareas = new List<Tarea>();
listaTareas.Add(new Tarea ("Examen", "recorda que hay una prueba ","el proximo fin de semana",1, false));
listaTareas.Add(new Tarea ("coso1", "recorda que hay una prueba ","el proximo fin de semana",2, true));
listaTareas.Add(new Tarea ("coso2", "recorda que hay una prueba ","el proximo fin de semana",3, false));

while (opcionWhile)
{
    Utilidades.MensajeAzul("------------------------------------------------------------------");
    Utilidades.MensajeAzul("#    [ 1 ]. Agregar Tarea                                        #");
    Utilidades.MensajeAzul("#    [ 2 ]. Ver Todas las Tareas                                 #");
    Utilidades.MensajeAzul("#    [ 3 ]. Marcar Tareas completadas                            #");
    Utilidades.MensajeAzul("#    [ 4 ]. Filtrar las Tareas                                   #");
    Utilidades.MensajeAzul("#    [ 5 ]. Salir                                                #");
    Utilidades.MensajeAzul("------------------------------------------------------------------");
    opcionMenu = Utilidades.LlenarNumeroEntero();
    switch (opcionMenu)
    {
        case 1:
            Console.Clear();
            Utilidades.TituloMensaje("┌────────────────┐");
            Utilidades.TituloMensaje("│ Agregar Tareas │");
            Utilidades.TituloMensaje("└────────────────┘");
            Tarea tarea = new Tarea();
            tarea.CrearTarea();
            listaTareas.Add(tarea);
            Utilidades.EsperaConfirmacion();

            break;
        case 2:
            Console.Clear();
            Utilidades.TituloMensaje("┌──────────────────────┐");
            Utilidades.TituloMensaje("│ VER TODAS LAS TAREAS │");
            Utilidades.TituloMensaje("└──────────────────────┘");
            
            foreach (Tarea tareas in listaTareas)
            {
                if (tareas != null)
                {
                    tareas.MostrarTareasTodasLasTareas();
                }
                else
                {
                    Utilidades.MensajeMorado("NO HAY TAREAS ASIGNADAS A LA LISTA");
                }
            }
            Utilidades.EsperaConfirmacion();
            break;
        case 3:
            Console.Clear();
            Utilidades.TituloMensaje("┌───────────────────────────┐");
            Utilidades.TituloMensaje("│ Marcar Tareas Completadas │");
            Utilidades.TituloMensaje("└───────────────────────────┘");
            foreach (Tarea tareas in listaTareas)
            {
                if (tareas.EstadoTarea == false)
                {
                    tareas.MostrarTareasTodasLasTareas();
                }
            }
            Utilidades.TituloMensaje("INGRESE EL NUMERO DE LA TAREA QUE DESEA COMPLETAR:");
            int numeroBuscado = Utilidades.LlenarNumeroEntero();
            foreach (Tarea tareas1 in listaTareas)
                {
                    if (tareas1.NumeroTarea == numeroBuscado)
                    {
                        tareas1.MarcarTareaCompletada();
                        tareas1.MostrarTareasTodasLasTareas();
                        Utilidades.MensajeMorado("**********************************************");
                        Utilidades.MensajeMorado("*     LA TAREA SE HA COMPLETADO CON EXITO    *");
                        Utilidades.MensajeMorado("**********************************************");
                    }
                }
            
            Utilidades.EsperaConfirmacion();
            break;
        case 4:
            Console.Clear();
            Utilidades.TituloMensaje("┌─────────────────────┐");
            Utilidades.TituloMensaje("│ Filtrar Las Tareas  │");
            Utilidades.TituloMensaje("└─────────────────────┘");

            Utilidades.MensajeAzul("[ 1 ]  TAREAS TERMINADAS" );
            Utilidades.MensajeAzul("[ 2 ]  TAREAS INCOMPLETAS" );

            opcionMenu = Utilidades.LlenarNumeroEntero();
                switch (opcionMenu)
                {
                    case 1:
                    foreach (Tarea tareas in listaTareas)
                    {
                        if (tareas.EstadoTarea == true)
                        {
                            tareas.MostrarTareasTodasLasTareas();
                        }
                    }
                        break; 

                    case 2:
                    foreach (Tarea tareas in listaTareas)
                    {
                        if (tareas.EstadoTarea == false)
                        {
                            tareas.MostrarTareasTodasLasTareas();
                        }
                    }
                    break;
                }
            Utilidades.EsperaConfirmacion();
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("SALIR");
            opcionWhile = false;
            Utilidades.EsperaConfirmacion();
            break;
            
    }
}