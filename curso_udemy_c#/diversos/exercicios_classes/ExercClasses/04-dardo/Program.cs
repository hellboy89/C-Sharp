using System;
using System.Globalization;

namespace _04_dardo {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite as tres distancias:");
            double dist1 = double.Parse(Console.ReadLine(), CI);
            double dist2 = double.Parse(Console.ReadLine(), CI);
            double dist3 = double.Parse(Console.ReadLine(), CI);

            double resultado = CalcDardo.MaiorDist(dist1, dist2, dist3);

            Console.WriteLine($"Maior Distancia = {resultado.ToString("F2", CI)}");

        }
    }
}
