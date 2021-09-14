using System;

namespace _04_menorDeTres {
    class Program {
        static void Main(string[] args) {
            Menor men = new Menor();

            Console.Write("Primeiro Valor: ");
            men.Valor1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            men.Valor2 = int.Parse(Console.ReadLine());

            Console.Write("Terceiro Valor: ");
            men.Valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine(men);

        }
    }
}
