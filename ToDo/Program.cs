// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using EspacioTareas;
const int cantidadDeTareas = 9;
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasCompletadas = new List<Tarea>();
for (int i = 0; i < cantidadDeTareas; i++)
{
    tareasPendientes.Add(new Tarea(Tarea.descripcionAleatoria(), RandomNumberGenerator.GetInt32(1, 24)));
}

foreach (var tarea in tareasPendientes)
{
   Console.WriteLine($"ID: {tarea.TareaID} Descripción: {tarea.Descripcion} - {tarea.Duracion}");;

}

int input;
int movidas=0;
do
{
    Console.WriteLine("Escriba la ID de la tarea (Escriba 0 para salir)");
    input = LeerNumeroMenorOIgualQue(cantidadDeTareas-movidas);
    if (input > 0)
    {
        tareasCompletadas.Add(tareasPendientes[input - 1]); //Ya que no uso la ID 0 para usarlo de exit
        tareasPendientes.Remove(tareasPendientes[input - 1]);
        movidas++;
    }
} while (input > 0);

    Console.WriteLine("-------------------------------TAREAS PENDIENTES-------------------------------------");
foreach (var tarea in tareasPendientes)
{
    Console.WriteLine($"ID: {tarea.TareaID} Descripción: {tarea.Descripcion}");

}

    Console.WriteLine("-------------------------------TAREAS COMPLETADAS-------------------------------------");
foreach (var tarea in tareasCompletadas)
{
    Console.WriteLine($"ID: {tarea.TareaID} Descripción: {tarea.Descripcion}");
}


int LeerNumeroMenorOIgualQue(int maximo)
{
    int a;
    bool Resultado;
    do
    {
        Console.WriteLine("Escriba un numero: ");
        Resultado = int.TryParse(Console.ReadLine(), out a);
        if (!Resultado || a>maximo)
        {
            Console.WriteLine("No es un número válido");
        }
    } while (!Resultado || a>maximo);
    return a;
}