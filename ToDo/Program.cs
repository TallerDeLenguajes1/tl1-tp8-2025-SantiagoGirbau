// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using EspacioTareas;
const int cantidadDeTareas = 7;
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasCompletadas = new List<Tarea>();

for (int i = 0; i < cantidadDeTareas; i++)
{
    tareasPendientes.Add(new Tarea(Tarea.descripcionAleatoria(), RandomNumberGenerator.GetInt32(1, 13)));
}

string input;
do
{
    Console.WriteLine("Escriba la operación que desea realizar: mover, buscar, mostrar o salir)");
    input = Console.ReadLine();

    switch (input)
    {
        case "mover":
            moverTareas(tareasPendientes, tareasCompletadas);
            break;
        case "mostrar":
            Console.WriteLine("-------------------------------TAREAS PENDIENTES-------------------------------------");
            mostrarLista(tareasPendientes);
            Console.WriteLine("-------------------------------TAREAS COMPLETADAS-------------------------------------");
            mostrarLista(tareasCompletadas);
            break;
        case "buscar":
            int found = buscarTarea(tareasPendientes);
            if (found >= 0)
            {
                mostrarTarea(tareasPendientes[found - 1]);
            }
            break;
        case "salir":
            break;
        default:
            Console.WriteLine("No es opción válida");
            break;
    }
} while (input != "salir");

void moverTareas(List<Tarea> tareasPendientes, List<Tarea> tareasCompletadas)
{
    int input;
    int cantidad = tareasPendientes.Count;
    do
    {
        Console.WriteLine("Escriba la ID de la tarea (Escriba 0 para salir)");
        input = LeerNumeroMenorOIgualQue(cantidad);
        if (input > 0)
        {
            tareasCompletadas.Add(tareasPendientes[input - 1]); //Ya que no uso la ID 0 para usarlo de exit
            tareasPendientes.Remove(tareasPendientes[input - 1]);
        }
    } while (input > 0);
}

void mostrarLista(List<Tarea> Lista)
{
    foreach (var tarea in Lista)
    {
        mostrarTarea(tarea);
    }
}

void mostrarTarea(Tarea tarea)
{
    Console.WriteLine($"ID: {tarea.TareaID} Descripción: {tarea.Descripcion} - {tarea.Duracion} hs");
}

int buscarTarea(List<Tarea> Lista)
{
    int found;
    Console.WriteLine("Escriba una palabra clave para buscar una tarea: ");
    string buscado = Console.ReadLine();
    foreach (var tarea in Lista)
    {
        if (tarea.Descripcion.Contains(buscado))
        {
            found = tarea.TareaID;
            return found;
        }
    }
    Console.WriteLine("No se encontró una tarea con esa palabra clave");
    return -1;
}

int LeerNumeroMenorOIgualQue(int maximo)
{
    int a;
    bool Resultado;
    do
    {
        Console.WriteLine("Escriba un numero: ");
        Resultado = int.TryParse(Console.ReadLine(), out a);
        if (!Resultado || a > maximo)
        {
            Console.WriteLine("No es un número válido");
        }
    } while (!Resultado || a > maximo);
    return a;
}