using System;
using System.Globalization;

namespace classesExercicio02 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Calculos calc = new Calculos();

            Console.Write("Nome: ");
            calc.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            calc.SalBrut = double.Parse(Console.ReadLine(), CI);
            Console.Write("Imposto: ");
            calc.Imposto = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"Funcionário: {calc.Nome}, $ {calc.SalComImposto().ToString("F2", CI)}");
            
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            calc.PorcAument = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"Dados Atualizados: {calc}");

        }
    }
}
