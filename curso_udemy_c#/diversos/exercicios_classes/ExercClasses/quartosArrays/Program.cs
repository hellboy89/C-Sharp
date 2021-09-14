using System;

namespace quartosArrays {
    class Program {
        static void Main(string[] args) {
            Quartos[] vetor = new Quartos[10];
            
            Console.Write("Quantos quartos serão alugados? ");
            int quantQuart = int.Parse(Console.ReadLine());


            for (int i = 0; i < quantQuart; i++) {
                Console.WriteLine();

                Console.WriteLine($"Aluguel #{i + 1}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());


                vetor[quarto] = new Quartos(nome, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (vetor[i] != null) {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }

        }
    }
}
