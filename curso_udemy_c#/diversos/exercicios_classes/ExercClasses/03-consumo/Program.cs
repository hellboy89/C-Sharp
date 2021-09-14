using System;
using System.Globalization;

namespace _03_consumo {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Distancia dist = new Distancia();

            Console.Write("Distancia percorrida: ");
            dist.DistPerc = double.Parse(Console.ReadLine(), CI);
            Console.Write("Combustível Gasto: ");
            dist.CombGast = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine(dist);


        }
    }
}
