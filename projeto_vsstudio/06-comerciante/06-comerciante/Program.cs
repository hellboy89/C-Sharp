using System;
using System.Globalization;

namespace _06_comerciante
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i, quantRep;
            double valTotComp = 0, valTotVend = 0, percentualLucro, abaixo = 0, entre = 0, acima = 0;

            Console.Write("Serão digitados dados de quantos produtos? ");
            quantRep = int.Parse(Console.ReadLine());

            string[] vetProd = new string[quantRep];
            double[] vetValComp = new double[quantRep];
            double[] vetValVend = new double[quantRep];

            for (i = 0; i < quantRep; i++)
            {
                Console.WriteLine($"Produto {i + 1}:");
                Console.Write("Nome: ");
                vetProd[i] = Console.ReadLine();
                Console.Write("Preço de compra: ");
                vetValComp[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Preço de venda: ");
                vetValVend[i] = double.Parse(Console.ReadLine(), CI);
            }

            for (i = 0; i < quantRep; i++)
            {
                valTotComp = valTotComp + vetValComp[i];
                valTotVend = valTotVend + vetValVend[i];
                percentualLucro = ((vetValVend[i] - vetValComp[i]) * 100) / vetValComp[i];
                if (percentualLucro < 10)
                {
                    abaixo++;
                }
                else if (percentualLucro <= 20)
                {
                    entre++;
                }
                else
                {
                    acima++;
                }
            }

            Console.WriteLine("\nRELATÓRIO: ");
            Console.Write($"\nLucro abaixo de 10%: {abaixo}");
            Console.Write($"\nLucro entre 10% e 20%: {entre}");
            Console.Write($"\nLucro acima de 20%: {acima}");
            Console.Write($"\nValor total de compra: R$ {valTotComp.ToString("F2", CI)}");
            Console.Write($"\nValor total de venda: R$ {valTotVend.ToString("F2", CI)}");
            Console.Write($"\nLucro total: R$ {(valTotVend - valTotComp).ToString("F2", CI)}\n");
        }
    }
}
