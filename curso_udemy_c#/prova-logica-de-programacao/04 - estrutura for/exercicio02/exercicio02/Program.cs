using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorX, valNum, i, contDentro = 0, contFora = 0;

            valorX = int.Parse(Console.ReadLine());

            for (i = 0; i < valorX; i++)
            {
                valNum = int.Parse(Console.ReadLine());
                if (valNum >= 10 && valNum <= 20)
                {
                    contDentro++;
                }
                else
                {
                    contFora++;
                }
            }

            Console.WriteLine($"{contDentro} In");
            Console.WriteLine($"{contFora} Out");


        }
    }
}
