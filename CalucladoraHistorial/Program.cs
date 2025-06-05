using EspacioCalculadora;
using Operaciones;
// See https://aka.ms/new-console-template for more information
List<Operacion> Historial = new List<Operacion>();
Calculadora numerito = new Calculadora();
string input;
double a;
int i = 0;
Operacion op;
do
{
    Console.WriteLine("Escriba la operación a realizar suma, resta, mult, div, limpiar, historial o exit para salir");
    input = Console.ReadLine();
    ;
    switch (input)
    {
        case "suma":
            a = LeerNumero();
            op = new Operacion(numerito.Resultado, a, Operacion.TipoOperacion.Suma);
            numerito.Sumar(a); //operacion
            Historial.Add(op);
            break;
        case "resta":
            a = LeerNumero();
            op = new Operacion(numerito.Resultado, a, Operacion.TipoOperacion.Resta);
            numerito.Restar(a);
             Historial.Add(op);
            break;
        case "mult":
            a = LeerNumero();
            op = new Operacion(numerito.Resultado, a, Operacion.TipoOperacion.Multiplicacion);
            numerito.Multiplicar(a);
            Historial.Add(op);
            break;
        case "div":
            a = LeerNumero();
            op = new Operacion(numerito.Resultado, a, Operacion.TipoOperacion.Division);
            if (a == 0)
            {
                Console.WriteLine("NO EXISTE LA DIVISIÓN EN CERO");
            }
            else
            {
                numerito.Dividir(a);
                Historial.Add(op);
            }
            break;
        case "limpiar":
            numerito.Limpiar();
            Console.WriteLine("Limpiado!");
            break;
         case "historial":
            int j = 1;
            foreach (var operacion in Historial)
            {
                Console.WriteLine($"{j}:");
                Console.WriteLine($"Valor inicial: {operacion.Resultado}");
                Console.WriteLine($"Operacion: {operacion.OperacionRealizada}");
                Console.WriteLine($"Valor aplicado: {operacion.NuevoValor}");
                j++;
            }
            break;
        case "exit":
            break;
        case "salir":
            break;
        default:
            Console.WriteLine("No es una opción válida");
            break;
    }
    i++;
    Console.WriteLine("Resultado = " + numerito.Resultado);
} while (input != "exit" && input != "salir");


float LeerNumero()
{
    float a;
    bool Resultado;
    do
    {
        Console.WriteLine("Escriba un numero: ");
        Resultado = float.TryParse(Console.ReadLine(), out a);
        if (!Resultado)
        {
            Console.WriteLine("No es un número válido");
        }
    } while (!Resultado);
    return a;
}

