using System;
using System.Globalization;

namespace exercicio01 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CI);
            ret.Altura = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"Area = {ret.Area().ToString("F2",CI)}");
            Console.WriteLine($"Perimetro = {ret.Perimetro().ToString("F2", CI)}");
            Console.WriteLine($"Diagonal = {ret.Diagonal().ToString("F2", CI)}");

        }
    }
}
