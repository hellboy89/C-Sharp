using System;
using System.Globalization;

namespace _03_troco
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double precoUni, quantComp, dinheiroRec, troco;

            Console.Write("Preço unitário do produto: ");
            precoUni = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantidade comprada: ");
            quantComp = double.Parse(Console.ReadLine(), CI);

            Console.Write("Dinheiro recebido: ");
            dinheiroRec = double.Parse(Console.ReadLine(), CI);

            troco = dinheiroRec - (precoUni * quantComp);

            Console.WriteLine("Troco = " + troco.ToString("F2", CI));
        }
    }
}
