using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exemploClasse {
    class Produto {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            double calc = Preco * Quantidade;
            return calc;
        }

        public void AdicionarProduto(int addQuantidade) {
            Quantidade = Quantidade + addQuantidade;
        }

        public void RemoverProduto(int remoQuantidade) {
            Quantidade = Quantidade - remoQuantidade;
        }

        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CI)
                + ", "
                + Quantidade
                + " Unidades, "
                + "Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CI)
                + "\n";
        }
    }
}
