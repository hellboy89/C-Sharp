using System;
using System.Globalization;

namespace _03_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double baseRet, altura, area, perimetro, diagonal;

            Console.Write("Base do retangulo: ");
            baseRet = double.Parse(Console.ReadLine(), CI);

            Console.Write("Altura do retangulo: ");
            altura = double.Parse(Console.ReadLine(), CI);

            area = baseRet * altura;
            perimetro = 2 * (baseRet + altura);
            diagonal = Math.Sqrt((baseRet * baseRet) + (altura * altura));

            Console.Write("\nArea = " + area.ToString("F4", CI));
            Console.Write("\nAltura = " + perimetro.ToString("F4", CI));
            Console.Write("\nDiagonal = " + diagonal.ToString("F4", CI));

        }
    }
}
