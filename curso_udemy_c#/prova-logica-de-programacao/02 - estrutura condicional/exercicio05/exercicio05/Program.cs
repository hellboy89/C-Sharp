using System;
using System.Globalization;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            string[] valores = Console.ReadLine().Split(' ');
            int codItem = int.Parse(valores[0]);
            int quantItem = int.Parse(valores[1]);
            double valorTot, precoItem;

            if (codItem == 1)
            {
                precoItem = 4.00;
                valorTot = quantItem * precoItem;
                Console.WriteLine($"Total: R$ {valorTot.ToString("F2", CI)}");
            }
            else if (codItem == 2)
            {
                precoItem = 4.50;
                valorTot = quantItem * precoItem;
                Console.WriteLine($"Total: R$ {valorTot.ToString("F2", CI)}");
            }
            else if (codItem == 3)
            {
                precoItem = 5.00;
                valorTot = quantItem * precoItem;
                Console.WriteLine($"Total: R$ {valorTot.ToString("F2", CI)}");
            }
            else if (codItem == 4)
            {
                precoItem = 2.00;
                valorTot = quantItem * precoItem;
                Console.WriteLine($"Total: R$ {valorTot.ToString("F2", CI)}");
            }
            else if (codItem == 5)
            {
                precoItem = 1.50;
                valorTot = quantItem * precoItem;
                Console.WriteLine($"Total: R$ {valorTot.ToString("F2", CI)}");
            }
            else
            {
                Console.WriteLine("Código incorreto, digite novamente!");
            }
        }
    }
}
