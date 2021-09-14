using System;
using System.Globalization;

namespace _teste_Datetime1 {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);

            // Mostrar a data atual e hora.
            DateTime d4 = DateTime.Now;

            // Mostrar somente o dia de hoje, com data zerada.
            DateTime d5 = DateTime.Today;

            // Mostra o horário global.
            DateTime d6 = DateTime.UtcNow;

            // Irá converter automaticamente a string em datetime.
            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:30");
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2020 13:30:10");

            // Convertendo datas para o meu padrão.
            CultureInfo CI = CultureInfo.InvariantCulture;
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CI);
            DateTime d12 = DateTime.ParseExact("2000-08-15 13:05:58", "yyyy-MM-dd HH:mm:ss", CI);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}

