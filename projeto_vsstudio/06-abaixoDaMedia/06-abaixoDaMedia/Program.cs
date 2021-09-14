using System;
using System.Globalization;

namespace _06_abaixoDaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i, quantRep;
            double contadorVet = 0, somaVet = 0, media;

            Console.Write("Quantos elementos vai ter o vetor? ");
            quantRep = int.Parse(Console.ReadLine());

            double[] vet = new double[quantRep];

            for (i = 0; i < quantRep; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            for (i = 0; i < quantRep; i++)
            {
                somaVet = somaVet + vet[i];
                contadorVet++;
            }

            media = somaVet / contadorVet;

            Console.Write($"\nMedia do Vetor = {media.ToString("F3", CI)}\n");
            Console.WriteLine("Elementos Abaixo da Media: ");
            for (i = 0; i < quantRep; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CI));
                }
            }
        }
    }
}
