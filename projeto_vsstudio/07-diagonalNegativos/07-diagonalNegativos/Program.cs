using System;

namespace _07_diagonalNegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, quantRep, somaNeg = 0;

            Console.Write("Qual a ordem da matriz: ");
            quantRep = int.Parse(Console.ReadLine());

            int[,] mat = new int[quantRep, quantRep];

            for (i = 0; i < quantRep; i++)
            {
                for (j = 0; j < quantRep; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nValores Digitados: ");
            for (i = 0; i < quantRep; i++)
            {
                for (j = 0; j < quantRep; j++)
                {
                    Console.Write($"{mat[i, j]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nDiagonal Principal: ");
            for (i = 0; i < quantRep; i++)
            {
                for (j = 0; j < quantRep; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{mat[i, j]} ");
                    }
                    if (mat[i, j] < 0)
                    {
                        somaNeg++;
                    }
                }
            }

            Console.Write($"\nQuantidade de Negativos = {somaNeg}\n");

        }
    }
}
