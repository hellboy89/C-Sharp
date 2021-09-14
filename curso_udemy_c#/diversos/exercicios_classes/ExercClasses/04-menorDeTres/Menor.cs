using System;
using System.Collections.Generic;
using System.Text;

namespace _04_menorDeTres {
    class Menor {
        public int Valor1;
        public int Valor2;
        public int Valor3;
        private int VarMenorValor = 0;

        public double MenorValor() {
            if (Valor1 < Valor2) {
                return VarMenorValor = Valor1;
            }
            else if (Valor2 < Valor3) {
                return VarMenorValor = Valor2;
            }
            else {
                return VarMenorValor = Valor3;
            }
        }

        public override string ToString() {
            return "Menor = "
                + MenorValor();
        }

    }
}
