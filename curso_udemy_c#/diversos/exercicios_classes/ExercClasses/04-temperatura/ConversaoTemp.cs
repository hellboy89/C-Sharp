using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _04_temperatura {
    class ConversaoTemp {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public static double CelParaFah(double celsius) {
            return (celsius * 1.8) + 32;
        }

        public static double FahParaCel(double fahrenheit) {
            return (fahrenheit - 32) / 1.8;
        }


    }
}
s