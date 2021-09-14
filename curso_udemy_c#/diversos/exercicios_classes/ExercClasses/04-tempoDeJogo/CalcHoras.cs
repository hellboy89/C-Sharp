using System;
using System.Collections.Generic;
using System.Text;

namespace _04_tempoDeJogo {
    class CalcHoras {

        public int HoraIni;
        public int HoraFin;
        public string Dado;

        public int ConvertTime() {
            int duracao = 24 - (24 + HoraIni - HoraFin) % 24;
            return duracao;
        }
    }
}
