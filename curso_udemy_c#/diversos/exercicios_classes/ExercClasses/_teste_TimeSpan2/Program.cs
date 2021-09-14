using System;

namespace _teste_TimeSpan2 {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine($"Em dias tem: {t1.Days}");
            int calcAnos = t1.Days / 365;
            int calcSec = t1.Days / (365 * 100);
            Console.WriteLine($"Em anos tem: {calcAnos}");
            Console.WriteLine($"Em séculos tem: {calcSec}");
            Console.WriteLine($"Em dias tem: {t2.Days}");

            Console.WriteLine();

            Console.WriteLine(t4);
            Console.WriteLine("Days: " + t4.Days);
            Console.WriteLine("Hours: " + t4.Hours);
            Console.WriteLine("Minutes: " + t4.Minutes);
            Console.WriteLine("Milliseconds: " + t4.Milliseconds);
            Console.WriteLine("Seconds: " + t4.Seconds);
            Console.WriteLine("Ticks: " + t4.Ticks);

            Console.WriteLine("TotalDays: " + t4.TotalDays);
            Console.WriteLine("TotalHours: " + t4.TotalHours);
            Console.WriteLine("TotalMinutes: " + t4.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t4.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t4.TotalMilliseconds);

            // Soma com timespan.
            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t5.Add(t6);
            TimeSpan dif = t5.Subtract(t6);
            TimeSpan mult = t5.Multiply(2.0);
            TimeSpan div = t5.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            Console.WriteLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Fazendo alterações depois do git reset soft head 1");
            Console.WriteLine("Enviando alterações para o github...");
        }
    }
}
