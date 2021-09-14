using System;
using System.Collections.Generic;
using System.Text;

namespace _03_duracao {
    class Duracao {
        public int Horas, Minutos, Segundos, Resto;

        public int CalcHoras() {
            return Segundos / 3600;
        }

        public int CalcResto() {
            return Segundos % 3600;
        }

        public int CalcMinutos() {
            return CalcResto() / 60;
        }

        public int CalcSegundos() {
            return CalcResto() % 60;
        }

        public override string ToString() {
            return CalcHoras()
                + " : "
                + CalcMinutos()
                + " : "
                + CalcSegundos();
        }
    }
}
