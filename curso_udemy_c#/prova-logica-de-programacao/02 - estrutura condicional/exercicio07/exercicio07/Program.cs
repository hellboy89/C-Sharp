using System;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double valorX = double.Parse(valores[0]);
            double valorY = double.Parse(valores[1]);

            if (valorX > 0 && valorY > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (valorX > 0 && valorY < 0) {
                Console.WriteLine("Q4");
            }
            else if (valorX == 0 && valorY == 0) {
                Console.WriteLine("Origem");
            }
            else
            {
                Console.WriteLine("Valores incorretos, tente novamente!");
            }


        }
    }
}
