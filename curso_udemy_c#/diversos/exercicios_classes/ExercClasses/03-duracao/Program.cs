using System;

namespace _03_duracao {
    class Program {
        static void Main(string[] args) {
            Duracao duracao = new Duracao();
            
            Console.Write("Digite a Duração em Segundos: ");
            duracao.Segundos = int.Parse(Console.ReadLine());

            Console.WriteLine(duracao);

        }
    }
}
