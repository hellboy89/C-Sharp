using System;
using System.Collections.Generic;
using System.Text;

namespace _03_idades {
    class Valores {
        public string Nome1;
        public string Nome2;
        public int Idade1;
        public int Idade2;

        public override string ToString() {
            return "A idade média de "
                + Nome1
                + " e "
                + Nome2
                + " é de "
                + (Idade1 + Idade2) / 2
                + " anos.";
        }
    }
}
