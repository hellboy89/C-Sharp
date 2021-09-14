using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _04_notas {
    class Valores {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public double Nota1;
        public double Nota2;

        public double NotaFinal() {
            return (Nota1 + Nota2);
        }

        public bool Aprovado() {
            if (NotaFinal() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public override string ToString() {
            return "Nota Final = "
                + NotaFinal().ToString("F1", CI);
        }
    }
}
