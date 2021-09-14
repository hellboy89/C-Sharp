using System;

namespace _05_crescente {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Digite dois numeros: ");
            int valX = int.Parse(Console.ReadLine());
            int valY = int.Parse(Console.ReadLine());


            while (valX != valY) {
                Crescente crescente = new Crescente(valX, valY);
                int resultado = Crescente.Ve

            }
        }
    }
}
