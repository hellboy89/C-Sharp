using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorX, i;

            valorX = int.Parse(Console.ReadLine());

            Console.WriteLine("Valores: ");
            for (i = 0; i < valorX; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
