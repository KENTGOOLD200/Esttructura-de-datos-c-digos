using System;

namespace FigurasGeometricas
{
    // Clase para representar un círculo
    public class Circulo
    {
        private double radio;

        // Constructor para inicializar el radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase para representar un rectángulo
    public class Rectangulo
    {
        private double longitud;
        private double anchura;

        // Constructor para inicializar la longitud y la anchura
        public Rectangulo(double longitud, double anchura)
        {
            this.longitud = longitud;
            this.anchura = anchura;
        }

        // Método para calcular el área del rectángulo
        public double CalcularArea()
        {
            return longitud * anchura;
        }

        // Método para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (longitud + anchura);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una variable para la instancia de Circulo
            Circulo miCirculo = new Circulo(5.0);
            Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

            // Crear una variable para la instancia de Rectangulo
            Rectangulo miRectangulo = new Rectangulo(4.0, 3.0);
            Console.WriteLine("Área del rectángulo: " + miRectangulo.CalcularArea());
            Console.WriteLine("Perímetro del rectángulo: " + miRectangulo.CalcularPerimetro());
        }
    }
}
