using System;

namespace _teste_Variaveis1 {
    class Program {
        static void Main(string[] args) {

            var var1 = 10;
            var var2 = 10.2;
            var var3 = "teste";
            var var4 = "10";
            var var5 = "vamos para a praia mané";


            Console.Write("Insira um valor: ");
            var var6 = int.Parse(Console.ReadLine());

            Console.WriteLine(var1.GetType());
            Console.WriteLine(var2.GetType());
            Console.WriteLine(var3.GetType());
            Console.WriteLine(var4.GetType());
            Console.WriteLine(var5.GetType());
            Console.WriteLine(var6.GetType());
        }
    }
}
