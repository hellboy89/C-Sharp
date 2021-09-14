using System;
using System.Globalization;

namespace _05_validacaoDeNota
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double nota1, nota2, media, soma = 0;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);

            while (nota1 < 0 || nota1 > 10)
            {
                Console.Write("Valor invalido! Tente novamente: ");
                nota1 = double.Parse(Console.ReadLine(), CI);
            }

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);

            while (nota2 < 0 || nota2 > 10)
            {
                Console.Write("Valor invalido! Tente novamente: ");
                nota2 = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine("\n\nMedia = " + ((nota1 + nota2) / 2).ToString("F2", CI));


        }
    }
}
