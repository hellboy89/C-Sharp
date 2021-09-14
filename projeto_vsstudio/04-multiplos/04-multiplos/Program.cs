using System;

namespace _04_multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite dois numeros inteiros: ");
            Console.Write("");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("");
            num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("São multiplos\n");
            }
            else
            {
                Console.WriteLine("Não são multiplos\n");
            }
        }
    }
}
