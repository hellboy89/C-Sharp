using System;
using System.Globalization;

namespace exercicio03 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CI);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CI);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"Nota Final = {aluno.NotaFinal().ToString("F2", CI)}");

            if (aluno.Aprovado()) {
                Console.WriteLine("Aprovado");
            }
            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltaram {aluno.NotaRestante().ToString("F2", CI)} Pontos");
            }
        }
    }
}
