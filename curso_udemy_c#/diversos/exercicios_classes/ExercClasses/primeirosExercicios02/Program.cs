using System;
using System.Globalization;

namespace primeirosExercicios02 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Variaveis p1 = new Variaveis();
            Variaveis p2 = new Variaveis();

            Console.WriteLine("Dados do Primeiro Funcionário: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            p1.Salario = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Dados do Segundo Funcionário: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            p2.Salario = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"\nSalario Medio:  {((p1.Salario + p2.Salario) / 2).ToString("F2", CI)}\n");

        }
    }
}
