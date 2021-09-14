using System;
using System.Globalization;

namespace _04_temperatura {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            string esc = Console.ReadLine();

            if (esc == "f") {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                double temp = double.Parse(Console.ReadLine(), CI);
                double resultado = ConversaoTemp.FahParaCel(temp);
                Console.Write($"Temperatura equivalente em Celsius: {resultado.ToString("F2", CI)}");
            }
            else {
                Console.Write("Digite a temperatura em Celsius: ");
                double temp = double.Parse(Console.ReadLine(), CI);
                double resultado = ConversaoTemp.CelParaFah(temp);
                Console.Write($"Temperatura equivalente em Fahrenheit: {resultado.ToString("F2", CI)}");
            }
        }
    }
}
