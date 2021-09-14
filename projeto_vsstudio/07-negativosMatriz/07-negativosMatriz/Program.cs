using System;

namespace _07_negativosMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, quantLinhas, quantColunas;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            quantLinhas = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz? ");
            quantColunas = int.Parse(Console.ReadLine());

            int[,] mat = new int[quantLinhas, quantColunas];

            for (i = 0; i < quantLinhas; i++)
            {
                for (j = 0; j < quantColunas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Valores Digitados: ");
            for (i = 0; i < quantLinhas; i++)
            {
                for (j = 0; j < quantColunas; j++)
                {
                    Console.Write($"{mat[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Valores Negativos: ");
            for (i = 0; i < quantLinhas; i++)
            {
                for (j = 0; j < quantColunas; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        Console.WriteLine($"{mat[i,j]} ");
                    }
                }
            }

        }
    }
}
