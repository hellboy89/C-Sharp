using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _03_consumo {
    class Distancia {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double DistPerc;
        public double CombGast;

        public double ConsumoMedio() {
            return DistPerc / CombGast;
        }

        public override string ToString() {
            return "Consumo medio = "
                + ConsumoMedio().ToString("F3", CI);
        }

    }
}
