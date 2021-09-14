using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _04_glicose {
    class CalcGlisose {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double Glicose;

        public string Medidor() {
            if (Glicose <= 100.0) {
                return "Classificacao: normal";
            }
            else if (Glicose > 100.0 && Glicose <= 140) {
                return "Classificacao: elevado";
            }
            else if (Glicose > 140.0) {
                return "Classificacao: diabetes";
            }
            else {
                return "Valor Incorreto, tente novamente";
            }
        }

        public override string ToString() {
            return Medidor();
        }

    }
}
