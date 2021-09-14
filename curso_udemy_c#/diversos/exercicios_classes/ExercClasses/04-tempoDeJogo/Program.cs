using System;

namespace _04_tempoDeJogo {
    class Program {
        static void Main(string[] args) {
            CalcHoras calc = new CalcHoras();
            
            Console.Write("Hora inicial: ");
            calc.HoraIni = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            calc.HoraFin = int.Parse(Console.ReadLine());


            if (calc.HoraIni == calc.HoraFin) {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else {
                Console.WriteLine($"O JOGO DUROU {calc.ConvertTime()} HORA(S)");
            }

        }
    }
}
