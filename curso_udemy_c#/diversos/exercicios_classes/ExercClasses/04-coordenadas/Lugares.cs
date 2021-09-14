using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _04_coordenadas {
    class Lugares {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public double ValX;
        public double ValY;

        public string Verifica() {
            if (ValX > 0 && ValY < 0) {
                return "Q4";
            }
            else if (ValX > 0 && ValY > 0) {
                return "Q1";
            }
            else if (ValX == 0 && ValY == 0) {
                return "Origem";
            }
            else if (ValX > 0 && ValY == 0) {
                return "Eixo X";
            }
            else if (ValX == 0 && ValY > 0) {
                return "Eixo X";
            }
            else {
                return null;
            }
        }

        public override string ToString() {
            return Verifica();
        }

    }
}
