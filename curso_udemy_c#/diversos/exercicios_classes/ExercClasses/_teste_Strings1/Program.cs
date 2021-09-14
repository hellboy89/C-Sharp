using System;

namespace _teste_Strings1 {
    class Program {
        static void Main(string[] args) {

            string teste = "   ";
            string original = "   abcde FGHIJ ABC abc DEFG     ";
            string nome = "Juan Cleber Faria Alves";

            // Deixa tudo maiúsculo.
            string s1 = original.ToUpper();
            
            // Deixa tudo minúsculo.
            string s2 = original.ToLower();
            
            // Remove todos os espaços do começo e fim.
            string s3 = original.Trim();
            
            // Encontra a posição na memória da palavra 'bc'.
            int n1 = original.IndexOf("bc");
            int n1_1 = nome.IndexOf("Cle");

            // Substring utilizado para cortar a saída do comando.
            // A variável original se manterá intacta, somente a saída será aterada.
            string s4 = original.Substring(3);

            // Abaixo irá manter somente entre as posições 3 e 5.
            // Se tiver dúvida do uso, só colocar a seta em cima das aspas que mostra.
            string s5 = original.Substring(3, 5);

            // Usando o replace para substituir a saída.
            // Também possível utilizar funções concatenadas.
            string s6 = original.Replace('a', 'x').Trim();
            string s7 = original.Replace("abc", "xy").Trim();

            // Testando se os valores foram preenchidos em uma variável.
            bool b1 = String.IsNullOrEmpty(original);

            // Testando se a variável é nula ou tem espaços em branco.
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"ToUpper: -{s1}-");
            Console.WriteLine($"ToLower: -{s2}-");
            Console.WriteLine($"Trim: -{s3}-");
            Console.WriteLine($"IndexOf: -{n1}-");
            Console.WriteLine($"IndexOf Nome: -{n1_1}-");
            Console.WriteLine($"Substring(3): -{s4}-");
            Console.WriteLine($"Substring(3, 5): -{s5}-");
            Console.WriteLine($"Replace('a', 'x'): -{s6}-");
            Console.WriteLine($"Replace('abc', 'xy'): -{s7}-");
            Console.WriteLine($"IsNullOrEmpty: -{b1}-");
            Console.WriteLine($"IsNullOrWhiteSpace: -{b2}-");
        }
    }
}
