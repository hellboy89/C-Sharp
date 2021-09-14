using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace classesExercicio01 {
    class Retangulo {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return 2 * (Largura + Altura);
        }

        public double Diagonal() {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString() {
            return "Area = "
                + Area().ToString("F2", CI)
                + "\nPerimetro = "
                + Perimetro().ToString("F2", CI)
                + "\nDiagonal = "
                + Diagonal().ToString("F2", CI);
        }
    }
}
