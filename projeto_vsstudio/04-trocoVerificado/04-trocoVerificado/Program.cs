using System;
using System.Globalization;

namespace _04_trocoVerificado
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double precoUni, quantComp, dinRec, valorTot;

            Console.Write("Preço unitário do produto: ");
            precoUni = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            quantComp = double.Parse(Console.ReadLine(), CI);
            Console.Write("Dinheiro recebido: ");
            dinRec = double.Parse(Console.ReadLine(), CI);

            valorTot = precoUni * quantComp;
            
            if (dinRec < valorTot)
            {
                Console.Write("Dinheiro insuficiente. Faltam R$ " + (valorTot - dinRec).ToString("f2", CI));
            }
            else
            {
                Console.Write("Troco = R$ " + (dinRec - valorTot).ToString("F2", CI));
            }


        }
    }
}
