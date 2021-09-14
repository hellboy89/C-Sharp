using System;
using System.Globalization;

namespace classesExercicio01 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CI);
            ret.Altura = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine(ret);
        }
    }
}
