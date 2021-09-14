using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _03_circulo {
    class Calculo {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double RaioCirc;

        public double Area() {
            return 3.14159 * (Math.Pow(RaioCirc, 2));
        }

        public override string ToString() {
            return "Area = "
                + Area().ToString("F3", CI);
        }
    }
}
