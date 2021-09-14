using System;
using System.Globalization;

namespace classesExercicio03 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Notas notas = new Notas();

            Console.Write("Nome do Aluno: ");
            notas.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            notas.Nota1 = double.Parse(Console.ReadLine(), CI);
            notas.Nota2 = double.Parse(Console.ReadLine(), CI);
            notas.Nota3 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine(notas);

            if (notas.Aprovado()) {
                Console.WriteLine("Aprovado");
            }
            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltaram {notas.NotasRestantes().ToString("F2", CI)}");
            }

        }
    }
}
