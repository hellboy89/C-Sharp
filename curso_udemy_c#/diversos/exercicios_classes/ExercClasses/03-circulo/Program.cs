using System;
using System.Globalization;

namespace _03_circulo {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Calculo calc = new Calculo();

            Console.Write("Digite o valor do raio do circulo: ");
            calc.RaioCirc = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine(calc);


        }
    }
}
