using System;
using System.Globalization;

namespace _03_terreno {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Calculos calc = new Calculos();

            Console.Write("Digite a largura do terreno: ");
            calc.LargTerreno = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o comprimento do terreno: ");
            calc.CompTerreno = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o valor do metro quadrado: ");
            calc.ValMetQuad = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"Area do terreno = {calc.AreaTerreno().ToString("F2", CI)}");
            Console.WriteLine($"Preco do terreno = {calc.PrecoTerreno().ToString("F2", CI)}");


        }
    }
}
