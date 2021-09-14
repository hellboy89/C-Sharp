using System;
using System.Globalization;

namespace _04_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double nota1, nota2, somaNota;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);

            somaNota = nota1 + nota2;
            Console.WriteLine("Nota final = " + somaNota.ToString("F1", CI));

            if (somaNota < 60)
            {
                Console.WriteLine("Reprovado!");
            }

        }
    }
}
