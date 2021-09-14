using System;
using System.Globalization;

namespace _06_alturas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i, quantRep;
            double somaPessoas = 0, somaAltura = 0, porcMenos16 = 0, somaIdades = 0;

            Console.Write("Quantas pessoas serão digitadas? ");
            quantRep = int.Parse(Console.ReadLine());

            double[] vetAltura = new double[quantRep];
            string[] vetNome = new string[quantRep];
            int[] vetIdade = new int[quantRep];

            for (i = 0; i < quantRep; i++)
            {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa: ");
                Console.Write("Nome: ");
                vetNome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                vetIdade[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                vetAltura[i] = double.Parse(Console.ReadLine(), CI);
            }

            for (i = 0; i < quantRep; i++)
            {
                somaAltura = somaAltura + vetAltura[i];
                somaIdades = somaIdades + vetIdade[i];
                somaPessoas++;
                if (vetIdade[i] < 16)
                {
                    porcMenos16 = porcMenos16 + 1;
                }
            }

            Console.Write("\nAltura media: " + (somaAltura / somaPessoas).ToString("F2", CI));
            Console.Write("\nPorcentagem de Pessoas com menos de 16 anos: " + ((porcMenos16 / quantRep) * 100).ToString("F2", CI));

            for (i = 0; i < quantRep; i++)
            {
                if (vetIdade[i] < 16)
                {
                    Console.Write("\n" + vetNome[i]);
                }
            }
        }
    }
}
