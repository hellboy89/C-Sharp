using System;
using System.Globalization;

namespace _teste_CondTernaria1 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double preco = 20;

            double sal = 999;

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            double aumentSal = (sal >= 1000) ? (sal * 0.10) + sal : (sal * 0.30) + sal;

            Console.WriteLine(desconto.ToString("F2", CI));

            Console.WriteLine($"O aumento é {aumentSal.ToString("F2", CI)}");

        }
    }
}
