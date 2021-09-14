using System;
using System.Globalization;

namespace _04_temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double tempFa, tempCe;
            char escTemp;

            Console.Write("Vai digitar a temperatura em qual escala (C/F)? ");
            escTemp = char.Parse(Console.ReadLine());

            if (escTemp == 'f')
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                tempFa = double.Parse(Console.ReadLine(), CI);
                tempCe = (5.0 / 9.0) * (tempFa - 32.0);
                Console.Write("\nTemperatura equivalente em Celsius: " + tempCe.ToString("F2", CI));
            }
            else if (escTemp == 'c')
            {
                Console.Write("Digite a temperatura em Celsius: ");
                tempCe = double.Parse(Console.ReadLine(), CI);
                tempFa = (tempCe * 1.8) + 32.0;
                Console.Write("\nTemperatura equivalente em Fahrenheit: " + tempFa.ToString("F2", CI));
            }
            else
            {
                Console.WriteLine("Valor incorreto, digite novamente, F ou C.");
            }



        }
    }
}
