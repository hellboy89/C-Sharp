using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int valorX = int.Parse(valores[0]);
            int valorY = int.Parse(valores[1]);
            
            while (true)
            {
                if (valorX > 0 && valorY > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (valorX > 0 && valorY < 0)
                {
                    Console.WriteLine("Quarto");
                }
                else if (valorX < 0 && valorY < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else if (valorX < 0 && valorY > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else
                {
                    break;
                }
                valores = Console.ReadLine().Split(' ');
                valorX = int.Parse(valores[0]);
                valorY = int.Parse(valores[1]);
            }

        }
    }
}
