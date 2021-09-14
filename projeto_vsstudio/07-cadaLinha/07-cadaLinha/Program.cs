using System;

namespace _07_cadaLinha
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, quantRep, maior;

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


            Console.WriteLine("Maior Elemento de Cada Linha: ");
            for (i = 0; i < quantRep; i++)
            {
                maior = mat[i, 0];
                for (j = 0; j < quantRep; j++)
                {
                    if (maior < mat[i,j])
                    {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine($"{maior}");
            }
        }
    }
}
