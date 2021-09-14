using System;
using System.Globalization;

namespace _04_notas {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Valores val = new Valores();

            Console.Write("Digite a primeira nota: ");
            val.Nota1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a segunda nota: ");
            val.Nota2 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine(val);

            if (val.Aprovado()) {
                Console.WriteLine("Aprovado");
            }
            else {
                Console.WriteLine("Reprovado");
            }


        }
    }
}
