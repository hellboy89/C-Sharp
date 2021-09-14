using System;
using System.Collections.Generic;
using System.Text;

namespace _03_soma {
    class Processos {
        public int ValorX;
        public int ValorY;

        public int Soma() {
            return ValorX + ValorY;
        }

        public override string ToString() {
            return "Soma = "
                + Soma();
        }
    }
}
