using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _04_dardo {
    class CalcDardo {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public static double Distancia;

        public static double MaiorDist(double dist1, double dist2, double dist3) {
            Distancia = dist1;

            if (Distancia < dist2) {
                Distancia = dist2;
                return Distancia;
            }
            else if (Distancia < dist3) {
                Distancia = dist3;
                return Distancia;
            }
            else {
                return Distancia;
            }
        }
    }
}
