using System;
using System.Globalization;

namespace _04_trocoVerificado {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Troco troc = new Troco();

            Console.Write("Preço unitário do produto: ");
            troc.PrecoUnit = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            troc.QuantComp = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            troc.DinRec = double.Parse(Console.ReadLine(), CI);

            if (troc.ValorTotComp() > troc.DinRec) {
                Console.WriteLine($"Dinheiro Insuficiente, Faltam {troc.TrocoFalta().ToString("F2", CI)} reais.");
            }
            else {
                Console.WriteLine(troc);
            }

            

        }
    }
}
