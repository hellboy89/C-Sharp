using System;

namespace _03_soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorX, valorY, soma;

            Console.Write("Digite o valor de X: ");
            valorX = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            valorY = int.Parse(Console.ReadLine());
            soma = valorX + valorY;

            Console.WriteLine("\nSoma = " + soma);


        }
    }
}
