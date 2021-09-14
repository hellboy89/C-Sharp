using System;
using System.Globalization;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int valRep, i;
            double valorX, resultado;

            valRep = int.Parse(Console.ReadLine());

            for (i = 0; i < valRep; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                float A = float.Parse(valores[0], CI);
                float B = float.Parse(valores[1], CI);
                float C = float.Parse(valores[2], CI);

                resultado = ((A * 2) + (B * 3) + (C * 5)) / 10;

                Console.WriteLine($"{resultado.ToString("F1", CI)}");
            }
        }
    }
}
