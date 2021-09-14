using System;
using System.Globalization;

namespace _05_mediaIdades
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double num = 1, media, cont = 0, soma = 0;

            Console.WriteLine("Digite as idades: ");
            while (num > 0)
            {
                Console.Write("");
                num = double.Parse(Console.ReadLine());
                if (num > 0)
                {
                    cont++;
                    soma = soma + num;
                }
            }

            if (cont == 0)
            {
                Console.WriteLine("Impossível Calcular");
            }
            else
            {
                Console.Write("Media = " + (soma / cont).ToString("F2", CI));
            }


        }
    }
}
