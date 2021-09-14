using System;
using System.Globalization;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int cod1, cod2, numPec1, numPec2;
            double valor1, valor2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            numPec1 = int.Parse(valores[1]);
            valor1 = double.Parse(valores[2], CI);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            numPec2 = int.Parse(valores[1]);
            valor2 = double.Parse(valores[2], CI);

            total = (valor1 * numPec1) + (valor2 * numPec2);

            Console.WriteLine($"Valor a pagar: R$ {total.ToString("F2", CI)}\n");

        }
    }
}
