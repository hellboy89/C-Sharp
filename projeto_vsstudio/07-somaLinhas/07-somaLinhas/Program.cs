using System;
using System.Globalization;

namespace _07_somaLinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i, j, quantCol, quantLin;
            double somaLinhas = 0;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            quantLin = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz? ");
            quantCol = int.Parse(Console.ReadLine());

            double[,] mat = new double[quantLin, quantCol];
            double[] vetSoma = new double[quantLin];

            for (i = 0; i < quantLin; i++)
            {
                Console.WriteLine($"Digite a quantidade da {i + 1}a. linha: ");
                for (j = 0; j < quantCol; j++)
                {
                    mat[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            Console.WriteLine("\nValores Digitados: ");
            for (i = 0; i < quantLin; i++)
            {
                for (j = 0; j < quantCol; j++)
                {
                    Console.Write($"{mat[i, j]}  ");
                }
                Console.WriteLine();
            }

            for (i = 0; i < quantLin; i++)
            {
                vetSoma[i] = 0;
                for (j = 0; j < quantCol; j++)
                {
                    vetSoma[i] = vetSoma[i] + mat[i, j];
                }
            }
            
            Console.WriteLine("Vetor Gerado: ");
            for (i = 0; i < quantLin; i++)
            {
                Console.WriteLine($"{vetSoma[i] }");
            }
        }
    }
}
