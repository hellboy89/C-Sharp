using System;

namespace _04_multiplos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite dois numeros inteiros: ");
            int val1 = int.Parse(Console.ReadLine());
            int val2 = int.Parse(Console.ReadLine());

            string resultado = Verificacao.VerMult(val1, val2);

            Console.WriteLine(resultado);

        }
    }
}
