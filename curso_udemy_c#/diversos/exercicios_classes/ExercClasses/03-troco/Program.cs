using System;
using System.Globalization;

namespace _03_troco {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Valores val = new Valores();

            Console.Write("Preco Unitário do produto: ");
            val.PrecUnit = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade Comprada: ");
            val.QuantComp = int.Parse(Console.ReadLine(), CI);
            Console.Write("Dinheiro Recebido: ");
            val.DinRec = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine(val);


        }
    }
}
