using System;
using System.Globalization;

namespace udemy_log_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int idade;
            double salario;
            string nome;
            char sexo;

            idade = 32;
            salario = 4560.3;
            nome = "Maria Silva";
            sexo = 'f';

            Console.WriteLine("a funcionária " + nome + ", sexo " 
                + sexo + ", ganha " + salario.ToString("f2", CI) +
                " e tem " + idade + " anos");


        }
    }
}
