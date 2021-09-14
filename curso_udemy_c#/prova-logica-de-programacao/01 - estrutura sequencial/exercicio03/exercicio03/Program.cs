using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, resultado;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            resultado = (a * b) - (c * d);

            Console.WriteLine($"Diferença = {resultado}\n");


        }
    }
}
