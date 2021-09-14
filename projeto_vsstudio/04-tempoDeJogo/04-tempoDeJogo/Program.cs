using System;

namespace _04_tempoDeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaIni, horaFinal, duracao, horaTot = 24;

            Console.Write("Hora Inicial: ");
            horaIni = int.Parse(Console.ReadLine());
            Console.Write("Hora Final: ");
            horaFinal = int.Parse(Console.ReadLine());

            duracao = horaTot - (horaTot + horaIni - horaFinal) % 24;

            if (horaIni == horaFinal)
            {
                Console.WriteLine("O jogo durou 24h");
            }
            else
            {
                Console.WriteLine("O jogo durou " + duracao + "h(s)");
            }

        }
    }
}
