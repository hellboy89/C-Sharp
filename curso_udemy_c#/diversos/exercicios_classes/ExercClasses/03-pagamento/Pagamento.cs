using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _03_pagamento {
    class Pagamento {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public string Nome;
        public double ValHora;
        public int HorasTrab;

        public double PagTot() {
            return ValHora * HorasTrab;
        }

        public override string ToString() {
            return "O pagamento para "
                + Nome
                + " deve ser "
                + PagTot().ToString("F2", CI);
        }
    }
}
