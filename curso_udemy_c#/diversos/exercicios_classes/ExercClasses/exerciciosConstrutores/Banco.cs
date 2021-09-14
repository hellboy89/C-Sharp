using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exerciciosConstrutores {
    class Banco {
        CultureInfo CI = CultureInfo.InvariantCulture;

        //Abaixo foi criado o propertie da função, o get significa que a função
        //poderá ser acessada, mas com o "private set", não será alterado o valor.
        public int Numero { get; set; }
        //Abaixo com o valor somente get; set;, poderá ser acessado e modificado
        //por outro arquivo a qualquer momento.
        public string Titular { get; set; }
        //Abaixo o saldo também será "private set", pois ele não será alterado diretamente
        //pelo programa, a alteração virá por meio das funções Deposito e Saque.
        //Por questão de segurança.
        public double Saldo { get; private set; }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        public override string ToString() {
            return "\nDados da conta atualizados: \n"
                + "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CI)
                + "\n";

        }
    }
}
