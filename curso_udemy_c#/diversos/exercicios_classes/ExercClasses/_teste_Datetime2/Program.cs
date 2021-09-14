using System;

namespace _teste_Datetime2 {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            // Convertendo data
            string s1 = d2.ToLongDateString();
            string s2 = d2.ToLongTimeString();
            string s3 = d2.ToShortDateString();
            string s4 = d2.ToShortTimeString();
            string s5 = d2.ToString();

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);

            // Adicionando horas ou dias numa data específica.

            DateTime d3 = DateTime.Now;
            
            // Com o parâmetro abaiox eu adiciono 7 dias há mais da minha data atual.
            DateTime d4 = d.AddDays(7);
            DateTime d5 = d.AddDays(30);

            // Mostrando dias faltantes entre parâmetros.
            TimeSpan t1 = d5.Subtract(d4);

            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(t1);

        }
    }
}
