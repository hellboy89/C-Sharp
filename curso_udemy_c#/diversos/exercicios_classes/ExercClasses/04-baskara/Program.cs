using System;
using System.Globalization;

namespace _04_baskara {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Formulas form = new Formulas();

            Console.Write("Coeficiente A: ");
            form.ValorA = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente B: ");
            form.ValorB = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente C: ");
            form.ValorC = double.Parse(Console.ReadLine(), CI);

            if (form.SemRaizes()) {
                Console.WriteLine("Esta equação não possui raizes reais.");
            }
            else {
                Console.WriteLine(form);
            }

        }
    }
}
