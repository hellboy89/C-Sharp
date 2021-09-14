using System;
using System.Globalization;


namespace exercicio02 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Funcionarios func = new Funcionarios();
            
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruno = double.Parse(Console.ReadLine(), CI);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {func}");

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CI);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {func}");

        }
    }
}
