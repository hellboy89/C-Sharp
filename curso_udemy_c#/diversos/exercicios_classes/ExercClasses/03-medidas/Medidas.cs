using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _03_medidas {
    class Medidas {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double MedidaA;
        public double MedidaB;
        public double MedidaC;

        public double Quadrado() {
            return Math.Pow(MedidaA, 2);
        }

        public double Triangulo() {
            return (MedidaA * MedidaB) / 2;
        }

        public double Trapezio() {
            return ((MedidaA + MedidaB) * MedidaC) / 2;
        }

        public override string ToString() {
            return "Area do Quadrado = "
                + Quadrado().ToString("F4", CI)
                + "\nArea do Triangulo = "
                + Triangulo().ToString("F4", CI)
                + "\nArea do Trapezio = "
                + Trapezio().ToString("F4", CI);
        }
    }
}
