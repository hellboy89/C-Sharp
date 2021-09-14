using System;
using System.Globalization;

namespace _04_glicose
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double glicose;

            Console.Write("Digite a medida da glicose: ");
            glicose = double.Parse(Console.ReadLine(), CI);

            if (glicose < 100)
            {
                Console.WriteLine("Classifição: Normal");
            }
            else if (glicose > 100 && glicose <= 140)
            {
                Console.WriteLine("Classificação: Elevado");
            }
            else if (glicose > 140)
            {
                Console.WriteLine("Classificação: Diabetes");
            }
            else
            {
                Console.WriteLine("Classificação: Inexistente.");
            }

        }
    }
}
