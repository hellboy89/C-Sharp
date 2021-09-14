using System;
using System.Globalization;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double valor = double.Parse(Console.ReadLine(), CI);

            if (valor >= 0 && valor <= 25)
            {
                Console.WriteLine("Intervalor [0,25]");
            }
            else if (valor > 25 && valor <= 50)
            {
                Console.WriteLine("Intervalor [25,50]");
            }
            else if (valor > 50 && valor <= 75)
            {
                Console.WriteLine("Intervalor [50,75]");
            }
            else if (valor > 75 && valor <= 100)
            {
                Console.WriteLine("Intervalor [75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo!");
            }

        }
    }
}
