using System;

namespace _06_somaVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, quantRep;

            Console.Write("Quantos valores vai ter cada vetor? ");
            quantRep = int.Parse(Console.ReadLine());

            int[] vet1 = new int[quantRep];
            int[] vet2 = new int[quantRep];
            int[] vetSoma = new int[quantRep];

            Console.WriteLine("Digite os valores do vetor A: ");
            for (i = 0; i < quantRep; i++)
            {
                Console.Write("");
                vet1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os valores do vetor B: ");
            for (i = 0; i < quantRep; i++)
            {
                Console.Write("");
                vet2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vetor resultante:  ");
            for (i = 0; i < quantRep; i++)
            {
                vetSoma[i] = vet1[i] + vet2[i];
                Console.WriteLine($"{vetSoma[i]}");
            }

        }
    }
}
