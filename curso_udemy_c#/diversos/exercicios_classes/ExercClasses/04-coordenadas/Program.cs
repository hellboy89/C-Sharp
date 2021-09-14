using System;
using System.Globalization;

namespace _04_coordenadas {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Lugares calc = new Lugares();

            Console.Write("Valor de X: ");
            calc.ValX = double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de Y: ");
            calc.ValY = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine(calc);

        }
    }
}
