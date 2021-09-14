using System;
using System.Globalization;

namespace _04_coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double valorX, valorY;

            Console.Write("Valor de X: ");
            valorX = double.Parse(Console.ReadLine());
            Console.Write("Valor de Y: ");
            valorY = double.Parse(Console.ReadLine());

            if (valorX > 0 && valorY > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (valorX < 0 && valorY < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (valorX > 0 && valorY < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (valorX == 0 && valorY == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (valorX > 0 && valorY == 0)
            {
                Console.WriteLine("Eixo X");
            }


        }
    }
}
