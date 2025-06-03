// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using EspacioTareas;
const int cantidadDeTareas = 4;
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasCompletadas = new List<Tarea>();
Console.WriteLine("Hello, World!");
for (int i = 0; i < cantidadDeTareas; i++)
{
    tareasPendientes.Add(new Tarea(RandomNumberGenerator.GetInt32(1, 24)));
}

foreach (var tarea in tareasPendientes)
{
    Console.WriteLine("Descipción: " + tarea.Descripcion);
}

do
{

} while (true);