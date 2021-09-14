using System;
using System.Globalization;

namespace _06_mediaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i, quantRep;
            double media, somaPares = 0, contPares = 0;

            Console.Write("Quantos elementos vai ter o vetor? ");
            quantRep = int.Parse(Console.ReadLine());

            int[] vet = new int[quantRep];

            for (i = 0; i < quantRep; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < quantRep; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    somaPares = somaPares + vet[i];
                    contPares++;
                }
            }

            media = somaPares / contPares;

            if (contPares > 1)
            {
                Console.Write($"\nMedia dos Pares = {media.ToString("F1", CI)}\n");
            }
            else
            {
                Console.Write("\nNenhum numero Par!\n");
            }

        }
    }
}
