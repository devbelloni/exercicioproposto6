using System;
using System.Globalization;

namespace exercicioproposto6 {
    class Program {
        static void Main(string[] args) {
            string[] linha = Console.ReadLine().Split(' ');
            double A = double.Parse(linha[0], CultureInfo.InvariantCulture);
            double B = double.Parse(linha[1], CultureInfo.InvariantCulture);
            double C = double.Parse(linha[2], CultureInfo.InvariantCulture);
            double triangulo = A * C / 2;
            double circulo = C * C * Math.PI;
            double trapezio = ((A + B) * C)/2;
            double quadrado = B * B;
            double retangulo = A * B; 
            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
