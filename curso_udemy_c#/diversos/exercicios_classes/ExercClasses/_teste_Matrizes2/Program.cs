using System;

namespace _teste_Matrizes2 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual a ordem da Matriz: ");
            int quantMat = int.Parse(Console.ReadLine());

            int[,] mat = new int[quantMat, quantMat];

            for (int i = 0; i < quantMat; i++) {
                for (int j = 0; j < quantMat; j++) {
                    Console.Write($"Digite o Elemento {i}:{j}: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Todos os valores digitados: ");
            for (int i = 0; i < quantMat; i++) {
                for (int j = 0; j < quantMat; j++) {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }

            int contNeg = 0;
            Console.WriteLine("Diagonal Principal");
            for (int i = 0; i < quantMat; i++) {
                for (int j = 0; j < quantMat; j++) {
                    if (i == j) {
                        Console.Write(mat[i,j] + " ");
                    }
                    if (mat[i,j] < 0) {
                        contNeg++;
                    }
                }
            }

            Console.WriteLine($"\nNúmeros Negativos: {contNeg}");


        }
    }
}
