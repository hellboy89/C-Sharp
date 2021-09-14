using System;
using System.Globalization;

namespace _03_medidas {
    class Program {
        static void Main(string[] args) {
            Medidas med = new Medidas();
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Digite a medida A: ");
            med.MedidaA = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida B: ");
            med.MedidaB = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida C: ");
            med.MedidaC = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine(med);

        }
    }
}
