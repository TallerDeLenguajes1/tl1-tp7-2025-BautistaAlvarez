namespace EspacioCalculadora{
    public class Calculadora{
        private double dato;

        public Calculadora (double dato = 0){ //constructor ¿inicializar en 0?
            this.dato = dato;
        }
        /*public Calculadora (double inicio = 0){
            dato = inicio;
        }*///esto es otra manera de inicializar, es lo mismo que el de arriba


        public void sumar(double termino){
            dato += termino;
        }

        public void restar(double termino)
        {
            dato -= termino;
        }

        public void multiplicar(double termino)
        {
            dato = dato * termino;
        }

        public void dividir(double termino)
        {
            if (termino != 0) dato = dato / termino;
            else Console.WriteLine("No se puede dividir en 0");
        }

        public void limpiar()
        {
            dato = 0;
        }
        
        public double Resultado //Propiedad(una funcion para obtener el dato privado) en este caso solo get, el set es para poder darle un valor fuera
        {
            get => dato;
        }
    }

}