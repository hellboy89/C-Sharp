using System;

namespace _03_soma {
    class Program {
        static void Main(string[] args) {
            Processos proc = new Processos();

            Console.Write("Digite o valor de X: ");
            proc.ValorX = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            proc.ValorY = int.Parse(Console.ReadLine());

            Console.WriteLine(proc);


        }
    }
}
