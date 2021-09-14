using System;
using System.Globalization;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int valRep, i;
            double resultado;

            valRep = int.Parse(Console.ReadLine());

            for (i = 0; i < valRep; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double A = double.Parse(valores[0]);
                double B = double.Parse(valores[1]);

                resultado = A / B;

                if (B == 0)
                {
                    Console.WriteLine("Divisão Impossível");
                }
                else
                {
                    Console.WriteLine($"{resultado.ToString("F1", CI)}");
                }

            }


        }
    }
}
