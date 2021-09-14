using System;

namespace ExercMatriz {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual o número de linhas: ");
            int quantLin = int.Parse(Console.ReadLine());
            Console.Write("Qual o número de colunas: ");
            int quantCol = int.Parse(Console.ReadLine());

            int[,] mat = new int[quantLin, quantCol];

            for (int i = 0; i < quantLin; i++) {
                for (int j = 0; j < quantCol; j++) {
                    Console.Write($"Elemento ({i}:{j}): ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Valores Digitados: ");
            for (int i = 0; i < quantLin; i++) {
                for (int j = 0; j < quantCol; j++) {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Informe um número: ");
            int escNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantLin; i++) {
                for (int j = 0; j < quantCol; j++) {
                    if (mat[i,j] == escNum) {
                        if (j > 0) {
                            Console.WriteLine($"Esquerda: {mat[i, j-1]}");
                        }
                        if (i > 0) {
                            Console.WriteLine($"Acima: {mat[i - 1, j]}");
                        }
                        if (j < quantCol - 1) {
                            Console.WriteLine($"Direito: {mat[i, j + 1]}");
                        }
                        if (i < quantLin - 1) {
                            Console.WriteLine($"Abaixo: {mat[i + 1, j]}");
                        }

                    }
                }
            }

        }
    }
}
