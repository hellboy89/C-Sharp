using System;
using System.Globalization;

namespace _04_baskara
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double coefA, coefB, coefC, x1, x2, x, raizX;

            Console.Write("Coeficiente A: ");
            coefA = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente B: ");
            coefB = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente C: ");
            coefC = double.Parse(Console.ReadLine(), CI);

            x = (coefB * coefB) - (4 * coefA * coefC);

            if (x < 0)
            {
                Console.WriteLine("Esta equação não possui raizes.");
            }
            else
            {
                raizX = Math.Sqrt(x);
                x1 = (-coefB + raizX) / (2 * coefA);
                x2 = (-coefB - raizX) / (2 * coefA);
                Console.WriteLine("\nX1 = " + x1.ToString("f4", CI));
                Console.WriteLine("X2 = " + x2.ToString("f4", CI));
            }

        }
    }
}
