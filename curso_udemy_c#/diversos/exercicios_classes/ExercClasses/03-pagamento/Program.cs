using System;
using System.Globalization;

namespace _03_pagamento {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Pagamento pag = new Pagamento();

            Console.Write("Nome: ");
            pag.Nome = Console.ReadLine();
            Console.Write("Valor por hora: ");
            pag.ValHora = double.Parse(Console.ReadLine(), CI);
            Console.Write("Horas Trabalhadas: ");
            pag.HorasTrab = int.Parse(Console.ReadLine());

            Console.WriteLine(pag);

        }
    }
}
