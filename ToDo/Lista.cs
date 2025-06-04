using System.Security.Cryptography;

namespace EspacioTareas
{

    public class Tarea
    {

        private int tareaID;
        private string descripcion;
        private int duracion;


        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int TareaID { get => tareaID; set => tareaID = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        static int contadorID = 1;
        public Tarea(string Descripcion, int Duracion)
        {
            TareaID = contadorID;
            contadorID++;
            this.Descripcion = Descripcion;
            this.Duracion = Duracion;
        }



        public static string descripcionAleatoria()
        {
            string descripcionGenerada;
            switch (RandomNumberGenerator.GetInt32(0, 16))
            {

                case 0:
                    descripcionGenerada = "Jugar al Counter";
                    break;
                case 1:
                    descripcionGenerada = "Programar en serio";
                    break;
                case 2:
                    descripcionGenerada = "Programar sin ganas";
                    break;
                case 3:
                    descripcionGenerada = "Procastinar limpiando la casa";
                    break;
                case 4:
                    descripcionGenerada = "Dormir la siesta";
                    break;
                case 5:
                    descripcionGenerada = "Crear servidor anual de Minecraft";
                    break;
                case 6:
                    descripcionGenerada = "Terminar trabajos prácticos pendientes";
                    break;
                case 7:
                    descripcionGenerada = "Scrollear en instagram";
                    break;
                case 8:
                    descripcionGenerada = "Considerar dejar la carrera";
                    break;
                case 9:
                    descripcionGenerada = "Ver animes pendientes";
                    break;
                case 10:
                    descripcionGenerada = "Gastarse toda la plata en jueguitos";
                    break;
                case 11:
                    descripcionGenerada = "Organizar una sesión de D&D";
                    break;
                case 12:
                    descripcionGenerada = "Llorar en silencio";
                    break;
                case 13:
                    descripcionGenerada = "Jugar una run del mazo negro del Balatro";
                    break;
                case 14:
                    descripcionGenerada = "Admirar mi RTX 3070TI EVGA RGB 12GB trple fan";
                    break;
                case 15:
                    descripcionGenerada = "Acariciar a Pipo";
                    break;
                default:
                    descripcionGenerada = "Esta descripción significa que algo salió mal :(";
                    break;
            }
            return descripcionGenerada;
        }
    }
}