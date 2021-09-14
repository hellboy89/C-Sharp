using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _04_lanchonete {
    class Produtos {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public static double ValoresProd(int codProd, int quantComp) {
            if (codProd == 1) {
                return (quantComp * 5.00);
            }
            else if (codProd == 2) {
                return (quantComp * 3.50);
            }
            else if (codProd == 3) {
                return (quantComp * 4.80);
            }
            else if (codProd == 4) {
                return (quantComp * 8.90);
            }
            else if (codProd == 5) {
                return (quantComp * 7.32);
            }
            else {
                return 0;
            }
        }
    }
}
