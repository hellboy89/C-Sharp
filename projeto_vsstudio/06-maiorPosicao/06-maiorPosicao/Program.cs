using System;
using System.Globalization;

namespace _06_maiorPosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i, quantRep, posicao = 0;
            double maior;

            Console.Write("Quantos numeros voce vai digitar? ");
            quantRep = int.Parse(Console.ReadLine());

            double[] vet = new double[quantRep];

            for (i = 0; i < quantRep; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            maior = vet[0];

            for (i = 0; i < quantRep; i++)
            {
                if (maior < vet[i])
                {
                    maior = vet[i];
                    posicao = i;
                }
            }

            Console.WriteLine("\nValores Digitados: ");
            for (i = 0; i < quantRep; i++)
            {
                Console.Write($"{vet[i].ToString("F2", CI)}  ");
            }

            Console.Write($"\n\nMaior valor = {maior.ToString("F2", CI)}");
            Console.Write($"\nPosicao do Maior Valor = {posicao}\n");

        }
    }
}
