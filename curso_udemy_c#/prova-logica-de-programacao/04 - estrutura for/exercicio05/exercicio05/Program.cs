using System;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, i, fatorial = 1;

            valor = int.Parse(Console.ReadLine());
            
            for (i = 1; i <= valor; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine($"{fatorial}");

        }
    }
}
