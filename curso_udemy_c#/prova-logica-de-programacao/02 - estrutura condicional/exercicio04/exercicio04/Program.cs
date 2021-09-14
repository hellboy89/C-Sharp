using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaIni = int.Parse(valores[0]);
            int horaFin = int.Parse(valores[1]);
            int duracao = 0;

            if (horaIni == horaFin)
            {
                Console.WriteLine("O jogo durou 24 hora(s)");
            }
            else if (horaIni < horaFin)
            {
                duracao = horaFin - horaIni;
                Console.WriteLine($"O jogo durou {duracao} hora(s).\n");
            }
            else
            {
                duracao = 24 - horaIni + horaFin;
                Console.WriteLine($"O jogo durou {duracao} hora(s).\n");
            }


        }
    }
}
