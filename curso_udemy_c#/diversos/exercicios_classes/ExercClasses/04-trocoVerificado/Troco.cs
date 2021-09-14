using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _04_trocoVerificado {
    class Troco {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double PrecoUnit;
        public int QuantComp;
        public double DinRec;

        public double ValorTotComp() {
            return QuantComp * PrecoUnit;
        }

        public double TrocoDar() {
            return (DinRec - (PrecoUnit * QuantComp));
        }

        public double TrocoFalta() {
            return ((PrecoUnit * QuantComp) - DinRec);
        }

        public override string ToString() {
            return "Troco = "
                + TrocoDar().ToString("F2", CI);
        }

    }
}
