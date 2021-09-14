using System;
using System.Globalization;

namespace _06_somaVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int i, quantRep;
            double somaVet = 0, contVet = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            quantRep = int.Parse(Console.ReadLine());

            double[] vet = new double[quantRep];

            for (i = 0; i < quantRep; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.Write("Valores digitados = ");
            for (i = 0; i < quantRep; i++)
            {
                Console.Write(vet[i].ToString("F1", CI) + " ");
                somaVet = somaVet + vet[i];
                contVet++;
            }

            Console.Write("\nSoma = " + somaVet);
            Console.Write("\nMedia = " + (somaVet / contVet).ToString("F2", CI));
            Console.WriteLine();
        }
    }
}
