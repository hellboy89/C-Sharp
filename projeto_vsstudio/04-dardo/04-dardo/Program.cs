using System;
using System.Globalization;

namespace _04_dardo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double dist1, dist2, dist3, maior;

            Console.WriteLine("Digite as três distancias: ");
            Console.Write("");
            dist1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("");
            dist2 = double.Parse(Console.ReadLine(), CI);
            Console.Write("");
            dist3 = double.Parse(Console.ReadLine(), CI);

            maior = dist1;

            if (dist2 > maior)
            {
                maior = dist2;
            }
            else
            {
                maior = dist3;
            }

            Console.Write("\n\nMaior Distancia = " + maior.ToString("F2", CI));

        }
    }
}
