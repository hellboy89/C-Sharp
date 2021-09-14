using System;

namespace _07_somaMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, quantLinhas, quantColunas, somaMat = 0;

            Console.Write("Quantas linhas vai ter cada matriz? ");
            quantLinhas = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter cada matriz? ");
            quantColunas = int.Parse(Console.ReadLine());

            int[,] mat1 = new int[quantLinhas, quantColunas];
            int[,] mat2 = new int[quantLinhas, quantColunas];

            Console.WriteLine("Digite os valores da matriz A: ");
            for (i = 0; i < quantLinhas; i++)
            {
                for (j = 0; j < quantColunas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite os valores da matriz B: ");
            for (i = 0; i < quantLinhas; i++)
            {
                for (j = 0; j < quantColunas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz Soma: ");
            for (i = 0; i < quantLinhas; i++)
            {
                for (j = 0; j < quantColunas; j++)
                {
                    somaMat = mat1[i, j] + mat2[i, j];
                    Console.Write($"{somaMat}  ");
                }
                Console.WriteLine();
            }

        }
    }
}
