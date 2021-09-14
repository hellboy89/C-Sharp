using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1, val2, soma;

            val1 = int.Parse(Console.ReadLine());
            val2 = int.Parse(Console.ReadLine());

            soma = val1 + val2;

            Console.WriteLine($"Soma = {soma}\n");


        }
    }
}
