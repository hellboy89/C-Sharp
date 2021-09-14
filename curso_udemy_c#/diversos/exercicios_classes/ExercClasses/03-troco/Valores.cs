using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _03_troco {
    class Valores {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public double PrecUnit;
        public int QuantComp;
        public double DinRec;

        public double Troco() {
            return DinRec - (QuantComp * PrecUnit);
        }

        public override string ToString() {
            return "Troco = "
                + Troco().ToString("F2", CI);
        }
    }
}
