using System;
using System.Globalization;

namespace exemploClasse {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Produto prod = new Produto();
            
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            prod.Preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade no estoque: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + prod);

            Console.Write("Digite o número de produtos a ser ADICIONADO ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            prod.AdicionarProduto(qte);

            Console.WriteLine("Dados atualizados: " + prod);

            Console.Write("Digite o número de produtos a ser REMOVIDO do estoque: ");
            int qteRem = int.Parse(Console.ReadLine());
            prod.RemoverProduto(qteRem);

            Console.WriteLine("Dados atualizados: " + prod);


        }
    }
}
