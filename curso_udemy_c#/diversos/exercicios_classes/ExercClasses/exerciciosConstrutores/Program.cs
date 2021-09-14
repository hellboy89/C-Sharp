using System;
using System.Globalization;

namespace exerciciosConstrutores {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Banco banco = new Banco();

            Console.Write("Entre o número da conta: ");
            banco.Numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            banco.Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string resp = Console.ReadLine().ToUpper();

            if (resp == "S") {
                Console.Write("Entre o valor de depósito inicial: ");
                double quantia = double.Parse(Console.ReadLine(), CI);
                banco.Deposito(quantia);
                Console.WriteLine($"\nDados da conta: \nConta {banco.Numero}, Titular: {banco.Titular}, Saldo: $ {banco.Saldo.ToString("F2", CI)}\n");
            }
            else {
                Console.WriteLine($"\nDados da conta: \nConta {banco.Numero}, Titular: {banco.Titular}, Saldo: $ {banco.Saldo.ToString("F2", CI)}\n");
            }

            Console.Write("Entre um valor para depósito: ");
            double quantia2 = double.Parse(Console.ReadLine(), CI);
            banco.Deposito(quantia2);

            Console.WriteLine(banco);

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CI);
            banco.Saque(saque);

            Console.WriteLine(banco);

        }
    }
}
