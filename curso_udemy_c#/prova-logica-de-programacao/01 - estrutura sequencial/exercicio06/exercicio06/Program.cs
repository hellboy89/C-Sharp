using System;
using System.Globalization;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double a, b, c, tri, cir, trap, quad, ret, pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CI);
            b = double.Parse(valores[1], CI);
            c = double.Parse(valores[2], CI);

            tri = a * c / 2.0;
            cir = pi * c * c;
            trap = (a + b) / 2.0 * c;
            quad = b * b;
            ret = a * b;

            Console.WriteLine($"Triangulo = {tri.ToString("F3", CI)}");
            Console.WriteLine($"Circulo = {cir.ToString("F3", CI)}");
            Console.WriteLine($"Trapezio = {trap.ToString("F3", CI)}");
            Console.WriteLine($"Quadrado = {quad.ToString("F3", CI)}");
            Console.WriteLine($"Retangulo = {ret.ToString("F3", CI)}\n");
        }
    }
}
