using System;
using System.Globalization;

namespace _06_aprovados
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i, quantRep;
            double media;

            Console.Write("Quantos alunos serão digitados? ");
            quantRep = int.Parse(Console.ReadLine());

            string[] vetNome = new string[quantRep];
            double[] vetNota1 = new double[quantRep];
            double[] vetNota2 = new double[quantRep];

            for (i = 0; i < quantRep; i++)
            {
                Console.WriteLine($"Digite nome, primeira e segunda noat do {i + 1}o aluno: ");
                vetNome[i] = Console.ReadLine();
                vetNota1[i] = double.Parse(Console.ReadLine(), CI);
                vetNota2[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine("Alunos Aprovados: ");
            for (i = 0; i < quantRep; i++)
            {
                media = (vetNota1[i] + vetNota2[i]) / 2;
                if (media >= 6.0)
                {
                    Console.WriteLine(vetNome[i]);
                }
            }

        }
    }
}
