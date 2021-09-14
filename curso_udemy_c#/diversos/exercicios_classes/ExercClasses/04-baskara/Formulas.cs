using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _04_baskara {
    class Formulas {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double ValorA;
        public double ValorB;
        public double ValorC;

        public double Calculo() {
            return (Math.Pow(ValorB, 2) - (4 * ValorA * ValorC));
        }

        public double CalcRaiz() {
            return Math.Sqrt(Calculo());
        }

        public bool SemRaizes() {
            if (Calculo() < 0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double X1() {
            return (- ValorB + CalcRaiz()) / (2 * ValorA);
        }

        public double X2() {
            return (- ValorB - CalcRaiz()) / (2 * ValorA);
        }

        public override string ToString() {
            return "X1 = "
                + X1().ToString("F4", CI)
                + "\nX2 = "
                + X2().ToString("F4", CI);
        }
    }
}
