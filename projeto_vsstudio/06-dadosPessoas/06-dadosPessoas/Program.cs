using System;
using System.Globalization;

namespace _06_dadosPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i, quantRep;
            double maiorAlt = 0, menorAlt = 0, contMulheres = 0, contHomens = 0, somaAltMulheres = 0;

            Console.Write("Quantas pessoas seerão digitadas? ");
            quantRep = int.Parse(Console.ReadLine());

            double[] vetAlt = new double[quantRep];
            char[] vetSexo = new char[quantRep];

            for (i = 0; i < quantRep; i++)
            {
                Console.Write($"Altura da {i + 1}a pessoa: ");
                vetAlt[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write($"Genero da {i + 1}a pessoa: ");
                vetSexo[i] = char.Parse(Console.ReadLine());
            }

            maiorAlt = vetAlt[0];
            menorAlt = vetAlt[0];

            for (i = 0; i < quantRep; i++)
            {
                if (maiorAlt < vetAlt[i])
                {
                    maiorAlt = vetAlt[i];
                }
                if (menorAlt > vetAlt[i])
                {
                    menorAlt = vetAlt[i];
                }
                if (vetSexo[i] == 'f')
                {
                    contMulheres++;
                    somaAltMulheres = somaAltMulheres + vetAlt[i];
                }
                else if (vetSexo[i] == 'm')
                {
                    contHomens++;
                }
            }

            Console.Write($"\nMenor Altura = {menorAlt.ToString("F2", CI)}");
            Console.Write($"\nMaior Altura = {maiorAlt.ToString("F2", CI)}");
            Console.Write($"\nMedia das alturas das mulheres = {(somaAltMulheres / contMulheres).ToString("F2", CI)}");
            Console.Write($"\nNumero de homens = {contHomens}\n");

        }
    }
}
