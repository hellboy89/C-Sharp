using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;

            while (senha != 2002)
            {
                senha = int.Parse(Console.ReadLine());
                if (senha != 2002)
                {
                    Console.WriteLine("Senha invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                }
            }


        }
    }
}
