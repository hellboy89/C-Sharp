using System;

namespace _05_crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorX = 1, valorY = 0;

            while (valorX != valorY)
            {
                Console.WriteLine("Digite dois numeros: ");
                Console.Write("");
                valorX = int.Parse(Console.ReadLine());
                Console.Write("");
                valorY = int.Parse(Console.ReadLine());
                if (valorX > valorY)
                {
                    Console.WriteLine("Decrescente!");
                }
                else if (valorX == valorY)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
            }
        }
    }
}
