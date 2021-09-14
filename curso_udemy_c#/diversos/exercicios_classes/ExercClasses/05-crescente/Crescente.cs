using System;
using System.Collections.Generic;
using System.Text;

namespace _05_crescente {
    class Crescente {
        public int ValY;
        public int ValX;

        public Crescente(int valX, int valY) {
            ValX = valX;
            ValY = valY;
        }

        public string VerificaOrd() {
            if (ValX > ValY) {
                return "Crescente!";
            }
            else {
                return "Decrescente;";
            }
        }
    }
}
