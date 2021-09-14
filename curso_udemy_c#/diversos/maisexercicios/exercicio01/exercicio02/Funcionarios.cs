using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exercicio02 {
    class Funcionarios {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome;
        public double SalarioBruno;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruno - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruno = SalarioBruno + (SalarioBruno * porcentagem / 100.0);
        }

        public override string ToString() {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CI);
        }
    }
}
