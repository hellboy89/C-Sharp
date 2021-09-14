using System;

namespace _06_negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, quantRep;

            Console.Write("Quantos numeros vc vai digitar: ");
            quantRep = int.Parse(Console.ReadLine());

            int[] vet = new int[quantRep];

            for (i = 0; i < quantRep; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDados digitados: ");
            for (i = 0; i < quantRep; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
