namespace Operaciones {
    public class Operacion
    {
        private double resultadoAnterior = 0; // Almacena el resultado previo al cálculo actual
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
        private TipoOperacion operacion;// El tipo de operación realizada

        public double Resultado { get => resultadoAnterior; set => resultadoAnterior = value; }



        // Propiedad pública para acceder al nuevo valor utilizado en la operación
        public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
        public TipoOperacion OperacionRealizada { get => operacion; set => operacion = value; }

        public enum TipoOperacion
        {
            Suma,
            Resta,
            Multiplicacion,
            Division,
            Limpiar // Representa la acción de borrar el resultado actual o el historial
        }

           public Operacion(double Resultado, double NuevoValor, TipoOperacion OperacionRealizada)
        {
            this.Resultado = Resultado;
            this.NuevoValor = NuevoValor;
            this.OperacionRealizada = OperacionRealizada;
        }

    }
}