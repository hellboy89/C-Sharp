using System;
using System.Globalization;

namespace _04_aumento
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double salarioAtual, salarioNovo;

            Console.Write("Digite o salario da pessoa: ");
            salarioAtual = double.Parse(Console.ReadLine(), CI);

            if (salarioAtual <= 1000.00)
            {
                Console.Write("\nNovo Salario = " + (salarioAtual + (salarioAtual * 0.20)).ToString("F2", CI));
                Console.Write("\nAumento = " + (salarioAtual * 0.20).ToString("F2", CI));
                Console.Write("\nPorcentagem = 20%\n");
            }
            else if (salarioAtual > 1000.00 && salarioAtual <= 3000.00)
            {
                Console.Write("\nNovo Salario = " + (salarioAtual + (salarioAtual * 0.15)).ToString("F2", CI));
                Console.Write("\nAumento = " + (salarioAtual * 0.15).ToString("F2", CI));
                Console.Write("\nPorcentagem = 15%\n");
            }
            else if (salarioAtual > 3000.00 && salarioAtual <= 8000.00)
            {
                Console.Write("\nNovo Salario = " + (salarioAtual + (salarioAtual * 0.10)).ToString("F2", CI));
                Console.Write("\nAumento = " + (salarioAtual * 0.10).ToString("F2", CI));
                Console.Write("\nPorcentagem = 10%\n");
            }
            else if (salarioAtual > 8000.00)
            {
                Console.Write("\nNovo Salario = " + (salarioAtual + (salarioAtual * 0.05)).ToString("F2", CI));
                Console.Write("\nAumento = " + (salarioAtual * 0.05).ToString("F2", CI));
                Console.Write("\nPorcentagem = 5%\n");
            }
            else
            {
                Console.Write("Incorreto, ninguém ganha isso.");
            }
        }
    }
}
