using System.Security.Cryptography;

namespace EspacioTareas
{

    public class Tarea
    {

        private int tareaID;
        private string descripcion;
        private int duracion;
        int contadorID = 1;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int TareaID { get => tareaID; set => tareaID = value; }
        public int Duracion { get => duracion; set => duracion = value; }


        public Tarea(string Descipción, int Duracion)
        {
            TareaID = contadorID;
            contadorID++;
            this.Descripcion = Descripcion;
            this.Duracion = Duracion;
        }



        public string descripcionAleatoria()
        {
            string descripcionGenerada;
            switch (RandomNumberGenerator.GetInt32(0, 9))
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
                default:
                    descripcionGenerada = "Esta descripción significa que algo salió mal :(";
                    break;

            }
            return descripcionGenerada;
        }
    }
}