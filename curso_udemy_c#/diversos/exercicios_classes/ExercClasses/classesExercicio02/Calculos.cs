using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace classesExercicio02 {
    class Calculos {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public string Nome;
        public double SalBrut;
        public double PorcAument;
        public double Imposto;

        public double SalComImposto() {
            return SalBrut - Imposto;
        }
        public double PorcSal() {
            return ((SalBrut * 0.10) + SalComImposto());
        }

        public override string ToString() {
            return Nome
                + ", R$ "
                + SalComImposto().ToString("F2", CI);
        }
    }
}
