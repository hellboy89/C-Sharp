using System;
using System.Globalization;

namespace _04_operadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int quantMin;

            Console.Write("Digite a quantidade de minutos: ");
            quantMin = int.Parse(Console.ReadLine(), CI);

            if (quantMin < 100)
            {
                Console.Write("Valor a pagar: R$ " + 50.ToString("F2", CI));
            }
            else
            {
                Console.Write("Valor a pagar: R$ " + (((quantMin - 100) * 2) + 50).ToString("F2", CI));
            }

        }
    }
}
