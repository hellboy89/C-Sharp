using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace classesExercicio03 {
    class Notas {
        CultureInfo CI = CultureInfo.CurrentCulture;
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double CalcMedia() {
            return (Nota1 + Nota2 + Nota3);
        }

        public bool Aprovado() {
            if (CalcMedia() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double NotasRestantes() {
            if (Aprovado()) {
                return 0.0;
            }
            else {
                return 60.0 - CalcMedia();
            }
        }

        public override string ToString() {
            return "Nota Final "
                + CalcMedia().ToString("F2", CI);
        }

    }
}
