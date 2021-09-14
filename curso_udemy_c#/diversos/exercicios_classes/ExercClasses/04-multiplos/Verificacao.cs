using System;
using System.Collections.Generic;
using System.Text;

namespace _04_multiplos {
    class Verificacao {

        public static string VerMult(int val1, int val2) {
            if (val1 % val2 == 0 || val2 % val1 == 0) {
                return "SÃO Multiplos";
            }
            else {
                return "NÃO SÃO Multiplos";
            }
        }

    }
}
