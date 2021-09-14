using System;
using System.Globalization;

namespace _03_consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double distPerc, combGast, consMed;

            Console.Write("Distancia percorrida: ");
            distPerc = double.Parse(Console.ReadLine(), CI);

            Console.Write("Combustível gasto: ");
            combGast = double.Parse(Console.ReadLine(), CI);

            consMed = distPerc / combGast;

            Console.WriteLine("\nConsumo médio = " + consMed.ToString("F3", CI));


        }
    }
}
