using System;

namespace _04_menorDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, menor;

            Console.Write("Primeiro Valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine());

            menor = valor1;

            if (valor1 < menor)
            {
                Console.Write("\nMenor = " + valor1);
            }
            else if (valor2 < menor)
            {
                Console.Write("\nMenor = " + valor2);
            }
            else
            {
                Console.Write("\nMenor = " + valor3);
            }

        }
    }
}
