using System;

namespace _teste_Case1 {
    class Program {
        static void Main(string[] args) {

            while (true) {

                Console.Write("Escolha um número: ");
                int x = int.Parse(Console.ReadLine());
                string dia;

                switch (x) {
                    case 1:
                        dia = "primeiro";
                        break;
                    case 50:
                        dia = "primeiro2";
                        break;
                    case 2:
                        dia = "segundo";
                        break;
                    case 3:
                        dia = "terceiro";
                        break;
                    case 4:
                        dia = "quarto";
                        break;
                    case 5:
                        dia = "cinco";
                        break;
                    case 555:
                        dia = "cinco cinco cinco";
                        break;
                    default:
                        dia = "invalido";
                        break;
                }

                Console.WriteLine("O dia é " + dia);
                Console.WriteLine("Teste HelloWorld");

            }

        }
    }
}
