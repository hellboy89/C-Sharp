using System;

namespace primeirosExercicios01 {
    class Program {
        static void Main(string[] args) {

            Variaveis p1 = new Variaveis();
            Variaveis p2 = new Variaveis();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade) {
                Console.Write($"Pessoa mais velha: {p1.Nome}");
            }
            else {
                Console.Write($"Pessoa mais velha: {p2.Nome}");
            }


        }
    }
}
