using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoComb, alcool = 0, gasolina = 0, diesel = 0;


            while (true)
            {
                tipoComb = int.Parse(Console.ReadLine());

                if (tipoComb == 1)
                {
                    alcool++;
                }
                else if (tipoComb == 2)
                {
                    gasolina++;
                }
                else if (tipoComb == 3)
                {
                    diesel++;
                }
                else if (tipoComb == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor incorreto, digite novamente");
                }

            }

            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");



        }
    }
}
