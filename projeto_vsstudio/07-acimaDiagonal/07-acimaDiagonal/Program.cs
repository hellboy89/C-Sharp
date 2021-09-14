using System;

namespace _07_acimaDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, quantRep, somaAcimaDiag = 0;

            Console.Write("Qual a ordem da matriz? ");
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

            Console.WriteLine("Valores Digitados: ");
            for (i = 0; i < quantRep; i++)
            {
                for (j = 0; j < quantRep; j++)
                {
                    Console.Write($"{mat[i, j]}  ");
                }
                Console.WriteLine();
            }

            for (i = 2; i < quantRep; i++)
            {
                for (j = 2; j < quantRep; j++)
                {
                    somaAcimaDiag = somaAcimaDiag + mat[i, j];
                }
            }

            Console.Write($"Soma dos elementos acima da diagnoal principal = {somaAcimaDiag}");

        }
    }
}
