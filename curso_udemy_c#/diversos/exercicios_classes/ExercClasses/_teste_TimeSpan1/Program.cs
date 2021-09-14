using System;

namespace _teste_TimeSpan1 {
    class Program {
        static void Main(string[] args) {

            // TimeSpan utilizado para calcular tempo.

            TimeSpan t1 = new TimeSpan(0, 1, 30);

            // Passando o timespan com os Ticks.
            // Ticks é a forma que todo o sistema calcula horário, baseado em nanosegundos.
            TimeSpan t2 = new TimeSpan(900000000L);

            // Com calculo de hh:mm:ss.
            TimeSpan t3 = new TimeSpan(2, 11, 30);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            // Criando um timespan referente a dias.
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMinutes(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2); 
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);

        }
    }
}
