using System;
using System.Globalization;

namespace exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double valImposto, resultado;

            valImposto = double.Parse(Console.ReadLine(), CI);

            if (valImposto >= 2000.01 && valImposto <= 3000.00)
            {
                resultado = (valImposto - 2000.0) * 0.08;
                Console.WriteLine($"R$ {resultado.ToString("F2", CI)}");
            }
            else if (valImposto >= 3000.01 && valImposto <= 4500.00)
            {
                resultado = (valImposto - 3000.00) * 0.18 + 1000.0 * 0.08;
                Console.WriteLine($"R$ {resultado.ToString("F2", CI)}");
            }
            else if (valImposto > 4500)
            {
                resultado = (valImposto - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                Console.WriteLine($"R$ {resultado.ToString("F2", CI)}");
            }
            else
            {
                Console.WriteLine("Isento de importo");
            }

        }
    }
}
