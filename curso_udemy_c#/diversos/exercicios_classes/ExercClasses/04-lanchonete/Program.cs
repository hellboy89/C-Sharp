using System;
using System.Globalization;

namespace _04_lanchonete {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Codigo do produto comprado: ");
            int codProd = int.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            int quantComp = int.Parse(Console.ReadLine());

            double resultado = Produtos.ValoresProd(codProd, quantComp);

            Console.WriteLine($"Valor a pagar: R$ {resultado.ToString("F2", CI)}");

        }
    }
}
