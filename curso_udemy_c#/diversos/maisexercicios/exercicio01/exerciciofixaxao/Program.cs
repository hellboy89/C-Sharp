using System;
using System.Globalization;

namespace exerciciofixaxao {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CI);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine($"Valor a ser pago em reais {result.ToString("F2", CI)}");
        }
    }
}
