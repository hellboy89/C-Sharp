using System;

namespace _teste_Matrizes1 {
    class Program {
        static void Main(string[] args) {

            double[,] matriz = new double[2, 4];

            // Informa o número de elementos da matriz.
            Console.Write("Número de elementos da Matriz: ");
            Console.WriteLine(matriz.Length);

            // Informa a quantidade de linhas da matriz.
            Console.Write("Número de linhas da Matriz: ");
            Console.WriteLine(matriz.Rank);

            // Mostra a quantidade de linhas coluna 0.
            Console.Write("Quantidade de linhas na coluna 0 é: ");
            Console.WriteLine(matriz.GetLength(0));

            // Mostra a quantidade de colunas 1.
            Console.Write("Quantidade de colunas 1 é: ");
            Console.WriteLine(matriz.GetLength(1));
        }
    }
}
