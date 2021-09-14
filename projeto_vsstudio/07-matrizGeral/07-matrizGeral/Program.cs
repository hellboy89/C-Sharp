using System;
using System.Globalization;

namespace _07_matrizGeral
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i, j, quantRep, escLinha, escColuna;
            double somaPositivos = 0;

            Console.Write("Qual a ordem da matriz? ");
            quantRep = int.Parse(Console.ReadLine());

            double[,] mat = new double[quantRep, quantRep];

            for (i = 0; i < quantRep; i++)
            {
                for (j = 0; j < quantRep; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            Console.WriteLine("Valores Digitados: ");
            for (i = 0; i < quantRep; i++)
            {
                for (j = 0; j < quantRep; j++)
                {
                    Console.Write($"{mat[i, j].ToString("F2", CI)}  ");
                    if (mat[i, j] > 0)
                    {
                        somaPositivos = somaPositivos + mat[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.Write($"\n\nSoma dos positivos: {somaPositivos}\n");

            Console.Write("Escolha uma linha: ");
            escLinha = int.Parse(Console.ReadLine());
            for (i = 0; i < quantRep; i++)
            {
                Console.Write($"{mat[escLinha, i].ToString("F2", CI)}  ");
            }
            Console.WriteLine();

            Console.Write("Escolha uma coluna: ");
            escColuna = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 0; i < quantRep; i++)
            {
                Console.Write($"{mat[i, escColuna].ToString("F2", CI)}  ");
            }

            Console.Write("\n\nDiagonal Principal: ");
            for (i = 0; i < quantRep; i++)
            {
                Console.Write(mat[i, i].ToString("F2", CI) + " ");
            }

            for (i = 0; i < quantRep; i++)
            {
                for (j = 0; j < quantRep; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        mat[i, j] = Math.Pow(mat[i, j], 2);
                    }
                }
            }

            Console.WriteLine("\n\nMatriz Alterada: ");

            for (i = 0; i < quantRep; i++)
            {
                for (j = 0; j < quantRep; j++)
                {
                    Console.WriteLine(mat[i,j].ToString("F2", CI) + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
