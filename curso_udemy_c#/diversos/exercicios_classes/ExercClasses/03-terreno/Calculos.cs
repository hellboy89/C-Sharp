using System;
using System.Collections.Generic;
using System.Text;

namespace _03_terreno {
    class Calculos {
        public double LargTerreno;
        public double CompTerreno;
        public double ValMetQuad;

        public double AreaTerreno() {
            return LargTerreno * CompTerreno;
        }

        public double PrecoTerreno() {
            return ValMetQuad * AreaTerreno();
        }


    }
}
