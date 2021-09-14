using System;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, valor;

            valor = int.Parse(Console.ReadLine());

            for (i = 1; i <= valor; i++)
            {
                if (valor % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
