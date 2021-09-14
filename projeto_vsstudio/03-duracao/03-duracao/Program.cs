using System;

namespace _03_duracao
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos, minutos, horas, resto;

            Console.Write("Digite a duracao em segundos: ");
            segundos = int.Parse(Console.ReadLine());

            horas = segundos / 3600;
            resto = segundos % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}
