using System;

namespace _05_senhaFixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int senhaOk = 2002, senha;
            
            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            if (senha == senhaOk)
            {
                Console.WriteLine("Acesso Permitido!");
            }
            else
            {
                while (true)
                {
                    if (senha != senhaOk)
                    {
                        Console.Write("Senha inválida! Tente novamente: ");
                        senha = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Acesso Permitido!");
                        break;
                    }
                }
            }

        }
    }
}
