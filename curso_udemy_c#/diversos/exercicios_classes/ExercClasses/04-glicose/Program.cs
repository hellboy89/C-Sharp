using System;
using System.Globalization;

namespace _04_glicose {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            CalcGlisose glic = new CalcGlisose();

            Console.Write("Digite a medida da glicose: ");
            glic.Glicose = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine(glic);


            
        }
    }
}
