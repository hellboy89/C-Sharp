using System;
using System.Globalization;

namespace _03_medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double medidaA, medidaB, medidaC, areaQuad, areaTri, areaTrap;

            Console.Write("Digite a medida A: ");
            medidaA = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida B: ");
            medidaB = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida C: ");
            medidaC = double.Parse(Console.ReadLine(), CI);

            areaQuad = medidaA * medidaA;
            areaTri = (medidaA * medidaB) / 2;
            areaTrap = ((medidaA + medidaB) * medidaC) / 2.0;

            Console.WriteLine("Area do quadrado = " + areaQuad.ToString("f4", CI));
            Console.WriteLine("Area do triangulo = " + areaTri.ToString("f4", CI));
            Console.WriteLine("Area do trapezio = " + areaTrap.ToString("f4", CI));
            Console.WriteLine();

        }
    }
}
