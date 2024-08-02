using System;

namespace EjercicioInterfaces
{
    interface IOperaciones
    {
        double CalcularAreaCirculo(double radio);
        double CalcularPerimetroCuadrado(double lado);
        double CalcularVolumenCubo(double lado);
        double CalcularAreaRectangulo(double largo, double ancho);
        double CalcularVolumenEsfera(double radio);
    }


    class Operaciones : IOperaciones
    {
        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double CalcularPerimetroCuadrado(double lado)
        {
            return 4 * lado;
        }

        public double CalcularVolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }

        public double CalcularAreaRectangulo(double largo, double ancho)
        {
            return largo * ancho;
        }

        public double CalcularVolumenEsfera(double radio)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
        }

        public void Imprimir()
        {
            Console.WriteLine("Calculadora de operaciones geométricas");
            Console.WriteLine("1. Área de un círculo");
            Console.WriteLine("2. Perímetro de un cuadrado");
            Console.WriteLine("3. Volumen de un cubo");
            Console.WriteLine("4. Área de un rectángulo");
            Console.WriteLine("5. Volumen de una esfera");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.Imprimir();

            Console.WriteLine("Seleccione una opción (1-5): ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el radio del círculo:");
                    double radioCirculo = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Área del círculo: {operaciones.CalcularAreaCirculo(radioCirculo)}");
                    break;
                case 2:
                    Console.WriteLine("Ingrese el lado del cuadrado:");
                    double ladoCuadrado = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Perímetro del cuadrado: {operaciones.CalcularPerimetroCuadrado(ladoCuadrado)}");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el lado del cubo:");
                    double ladoCubo = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Volumen del cubo: {operaciones.CalcularVolumenCubo(ladoCubo)}");
                    break;
                case 4:
                    Console.WriteLine("Ingrese el largo del rectángulo:");
                    double largoRectangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el ancho del rectángulo:");
                    double anchoRectangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Área del rectángulo: {operaciones.CalcularAreaRectangulo(largoRectangulo, anchoRectangulo)}");
                    break;
                case 5:
                    Console.WriteLine("Ingrese el radio de la esfera:");
                    double radioEsfera = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Volumen de la esfera: {operaciones.CalcularVolumenEsfera(radioEsfera)}");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
