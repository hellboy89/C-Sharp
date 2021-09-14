using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _teste1 {
    public class ClassTeste1 {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double Val1;
        public double Val2;
        public double Val3;
        public double Soma;
        public string Nome;

        public ClassTeste1(CultureInfo cI, double val1, double val2, double val3, double soma, string nome) {
            CI = cI;
            Val1 = val1;
            Val2 = val2;
            Val3 = val3;
            Soma = soma;
            Nome = nome;
        }

        public void PrintNome() {
            Nome = "Juan Cleber";
            Console.WriteLine($"Meu nome é {this.Nome}");
        }

        public ClassTeste1(double val1, double val2, double val3) {
            Val1 = val1;
            Val2 = val2;
            Val3 = val3;    
        }

        public double SomaTudo() {
            Soma = Val1 + Val2 + Val3;
            return Soma;
        }

        public override string ToString() {
            return "Soma de Tudo = "
                + SomaTudo().ToString("F10", CI);
        }

    }
}
