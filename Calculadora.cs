namespace EspacioCalculadora{
    public class Calculadora(){
        private int n1;
        public int N1{
            get => n1;
            set => n1 = value;
        }
        private int n2;
        public int N2{
            get => n2;
            set => n2 = value;
        }
            
        private float resultado;
        public float R{
            get => resultado;
            set => resultado = value;
        }
        public void sumar(){
            resultado = N1 + N2;
        }
        public void restar(){
            resultado = N1 - N2;
        }
        public void multiplicar(){
            resultado = N1 * N2;
        }
        public void dividir(){
            resultado = N1 / N2;
        }
    }
    public class Operacion{
        private double resultadoAnterior;
        private double nuevoValor;
        public TipoOperacion operacion{
            get;
            set;
        }
        public double ResultadoAnterior{
            get;set;
        }
        public double NuevoValor{
            get;set;
        }
        public enum TipoOperacion{
            Suma,
            Resta,
            Multiplicacion,
            Division,
            Limpiar
        }
    }
}