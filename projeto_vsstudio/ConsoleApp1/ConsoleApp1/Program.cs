using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            string nome;
            double valorHora, horasTrab, totPag;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Valor por Hora: ");
            valorHora = double.Parse(Console.ReadLine(), CI);

            Console.Write("Horas trabalhadas: ");
            horasTrab = double.Parse(Console.ReadLine(), CI);

            totPag = valorHora * horasTrab;

            Console.WriteLine("\nO pagamento para " + nome + " deve ser " + totPag.ToString("F2", CI));

        }
    }
}
