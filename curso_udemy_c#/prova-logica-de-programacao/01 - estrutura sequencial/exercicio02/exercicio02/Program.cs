using System;
using System.Globalization;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double area, num, pi = 3.14159;

            num = double.Parse(Console.ReadLine(), CI);
            area = pi * num * num;

            Console.WriteLine($"A = {area.ToString("F4", CI)}");

        }
    }
}
