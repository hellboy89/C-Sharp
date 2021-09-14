using System;

namespace _05_quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorX = 1, valorY = 1;


            while (valorX != 0 && valorY != 0)
            {
                Console.WriteLine("Digite os valores das coordenadas X e Y: ");
                Console.Write("");
                valorX = int.Parse(Console.ReadLine());
                Console.Write("");
                valorY = int.Parse(Console.ReadLine());

                if (valorX > 0 && valorY > 0)
                {
                    Console.WriteLine("Quadrante Q1");
                }
                else if (valorX > 0 && valorY < 0)
                {
                    Console.WriteLine("Quadrante Q4");
                }
                else if (valorX < 0 && valorY > 0)
                {
                    Console.WriteLine("Quadrante Q2");
                }
                else if (valorX < 0 && valorY < 0)
                {
                    Console.WriteLine("Quadrante Q3");
                }
            }
        }
    }
}
