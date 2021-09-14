using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _04_operadora {
    class CalcOperadora {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public int QuantMinutos;
        public double ValPag;

        public double ValorPagar() {
            if (QuantMinutos <= 100.0) {
                return ValPag = 50.00;
            }
            else {
                return ((QuantMinutos - 100) * 2) + 50;
            }
        }

        public override string ToString() {
            return "Valor a pagar: R$ "
                + ValorPagar().ToString("F2", CI);
        }
    }
}
