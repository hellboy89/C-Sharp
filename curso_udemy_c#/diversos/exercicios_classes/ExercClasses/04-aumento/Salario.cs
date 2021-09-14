using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _04_aumento {
    class Salario {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public static double CalcSalario(double salario) {
            if (salario <= 1000.0) {
                double novoSal = (salario * 0.20) + salario;
                return novoSal;
            }
            else if (salario > 1000.0 && salario <= 3000.0) {
                double novoSal = (salario * 0.15) + salario;
                return novoSal;
            }
            else if (salario > 3000.0 && salario <= 8000.0) {
                double novoSal = (salario * 0.10) + salario;
                return novoSal;
            }
            else if (salario > 8000.0) {
                double novoSal = (salario * 0.05) + salario;
                return novoSal;
            }
            else {
                return 0;
            }
        }

    }
}
