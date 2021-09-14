using System;
using System.Globalization;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int numFun, horasTrab;
            double salario;

            numFun = int.Parse(Console.ReadLine());
            horasTrab = int.Parse(Console.ReadLine());
            salario = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"Number = {numFun}");
            Console.WriteLine($"Salary = U$ {(horasTrab * salario).ToString("F2", CI)}\n");

        }
    }
}
