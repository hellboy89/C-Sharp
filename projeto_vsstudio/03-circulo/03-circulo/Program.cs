using System;
using System.Globalization;

namespace _03_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double raio, area;

            Console.Write("Digite o valor do raio do circulo: ");
            raio = double.Parse(Console.ReadLine(), CI);

            area = 3.14159 * (raio * raio);

            Console.WriteLine("Area = " + area.ToString("F3", CI));

        }
    }
}
