using System;
using System.Globalization;

namespace _04_aumento {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            

            Console.Write("Digite o salario da pessoa: ");
            double salario = double.Parse(Console.ReadLine(), CI);

            if (salario <= 1000.0) {
                double resultado = Salario.CalcSalario(salario);
                Console.WriteLine($"Novo salario = {resultado.ToString("F2", CI)}");
                double CalcSal = (salario * 0.20);
                Console.WriteLine($"Aumento = {CalcSal.ToString("F2", CI)}");
                Console.WriteLine("Porcentagem = 20%");
            }
            else if (salario > 1000.0 && salario <= 3000.0) {
                double resultado = Salario.CalcSalario(salario);
                Console.WriteLine($"Novo salario = {resultado.ToString("F2", CI)}");
                double CalcSal = (salario * 0.15);
                Console.WriteLine($"Aumento = {CalcSal.ToString("F2", CI)}");
                Console.WriteLine("Porcentagem = 15%");
            }
            else if (salario > 3000.0 && salario <= 8000.0) {
                double resultado = Salario.CalcSalario(salario);
                Console.WriteLine($"Novo salario = {resultado.ToString("F2", CI)}");
                double CalcSal = (salario * 0.10);
                Console.WriteLine($"Aumento = {CalcSal.ToString("F2", CI)}");
                Console.WriteLine("Porcentagem = 10%");
            }
            else if (salario > 8000.0) {
                double resultado = Salario.CalcSalario(salario);
                Console.WriteLine($"Novo salario = {resultado.ToString("F2", CI)}");
                double CalcSal = (salario * 0.05);
                Console.WriteLine($"Aumento = {CalcSal.ToString("F2", CI)}");
                Console.WriteLine("Porcentagem = 5%");
            }
            else {
                Console.WriteLine("Valor incorreto, digite novamente!");
            }

        }
    }
}
