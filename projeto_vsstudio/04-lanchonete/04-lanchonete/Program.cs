using System;
using System.Globalization;

namespace _04_lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double codProd, quantComp, valorPag = 0;

            Console.Write("Codigo do produto comprado: ");
            codProd = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            quantComp = double.Parse(Console.ReadLine(), CI);

            if (codProd == 1)
            {
                valorPag = 5.00 * quantComp;
            }
            else if (codProd == 2)
            {
                valorPag = 3.50 * quantComp;
            }
            else if (codProd == 3)
            {
                valorPag = 4.80 * quantComp;
            }
            else if (codProd == 4)
            {
                valorPag = 8.90 * quantComp;
            }
            else if (codProd == 5)
            {
                valorPag = 7.32 * quantComp;
            }
            else
            {
                Console.WriteLine("Valor incorreto, tente novamente!");
            }

            Console.Write("\n\nValor a pagar: " + valorPag.ToString("F2", CI));
        }
    }
}
