using System;

namespace _06_maisVelho
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, quantRep, maisVelho, posicao = 0;

            Console.Write("Quantas pessoas vc vai digitar? ");
            quantRep = int.Parse(Console.ReadLine());

            string[] vetNome = new string[quantRep];
            int[] vetIdade = new int[quantRep];

            for (i = 0; i < quantRep; i++)
            {
                Console.WriteLine($"Dados da {i+1}a pessoa: ");
                Console.Write("Nome: ");
                vetNome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                vetIdade[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            maisVelho = vetIdade[0];

            for (i = 0; i < quantRep; i++)
            {
                if (maisVelho < vetIdade[i])
                {
                    maisVelho = vetIdade[i];
                    posicao = i;
                }
            }

            Console.Write($"\n\nPessoa Mais Velho: {vetNome[posicao]}\n");

        }
    }
}
