using System;
using System.Globalization;

namespace _04_operadora {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            CalcOperadora calc = new CalcOperadora();

            Console.Write("Digite a quantidade de minutos: ");
            calc.QuantMinutos = int.Parse(Console.ReadLine());

            Console.WriteLine(calc);

        }
    }
}
