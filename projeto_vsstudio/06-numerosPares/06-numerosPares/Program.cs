using System;

namespace _06_numerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, quantRep, somaPares = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            quantRep = int.Parse(Console.ReadLine());

            int[] vet = new int[quantRep];

            for (i = 0; i < quantRep; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNumero de Pares: ");
            for (i = 0; i < quantRep; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write($"{vet[i]} ");
                    somaPares++;
                }
            }

            Console.Write($"\nQuantidade de pares = {somaPares}\n");

        }
    }
}
