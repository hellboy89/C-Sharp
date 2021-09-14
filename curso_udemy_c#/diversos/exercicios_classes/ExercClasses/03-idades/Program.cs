using System;

namespace _03_idades {
    class Program {
        static void Main(string[] args) {
            Valores val = new Valores();
            
            Console.WriteLine(" Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            val.Nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            val.Idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            val.Nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            val.Idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine(val);


        }
    }
}
