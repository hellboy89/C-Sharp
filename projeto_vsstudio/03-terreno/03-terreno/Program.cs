using System;
using System.Globalization;

namespace _03_terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double larg, comp, valorMetQuad, areaTot, precoTot;

            Console.Write("Digite a largura do terreno: ");
            larg = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite o comprimento do terreno: ");
            comp = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite o valor do metro quadrado: ");
            valorMetQuad = double.Parse(Console.ReadLine(), CI);

            areaTot = larg * comp;
            precoTot = areaTot * valorMetQuad;

            Console.Write("\nArea do terreno = " + areaTot.ToString("F2", CI));
            Console.Write("\nPreço do terreno = R$" + precoTot.ToString("F2", CI));
            Console.WriteLine();
        }
    }
}
