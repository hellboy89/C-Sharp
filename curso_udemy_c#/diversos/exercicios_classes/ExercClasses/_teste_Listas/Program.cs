using System;
using System.Collections.Generic;

namespace _teste_Listas {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            List<string> list2 = new List<string>() { "Juan", "Cleber", "Faria", "Alves" };

            List<string> list3 = new List<string>();

            list3.Add("Maria");
            list3.Add("Alex");
            list3.Add("Bob");
            list3.Add("Anna");
            list3.Insert(2, "Marco");

            list2.Add("\n");
            list2.Add("Denise");
            list2.Add("Cleberson");
            list2.Add("da Rocha");
            list2.Add("Faria");
            list2.Add("Alves");

            list2.Insert(3, "Farofa");
            list2.Insert(0, "Clementino");
            list2.Insert(12, "Ian");
            list2.RemoveAt(2);

            list2.Insert(8, "Alvarenga");
            list2.RemoveAt(9);

            Console.WriteLine($"A contagem de ITENS da lista é {list2.Count}");


            Console.WriteLine("USANDO FOREACH...");
            
            // Nova forma abaixo de imprimir linha por linha. TESTAR MAIS!
            foreach (string obj in list3) {
                Console.WriteLine(obj);
            }

            // Encontrar a letra A na primeira posição.
            string s1 = list3.Find(x => x[0] == 'A');
            Console.WriteLine($"First 'A': {s1}");

            // Entrar a letra A na última posição, mostrar toda palavra.
            string s2 = list3.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s2}");

            // Apenas encontrar a letra A, na primeira posição da palavra.
            string s3 = list3.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Ultimo com A: {s3}");

            // Encontrar a posição da letra A em qualquer lugar da palavra.
            int pos1 = list3.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Primeira posição 'A': {pos1}");

            // Encontrar a posição da letra no último caracter.
            int pos2 = list3.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last position 'A': {pos2}");

            // Remover entrada da lista pelo nome.
            list2.Remove("Denise");

            // Abaixo usando o parâmetro FindAll, ele irá encontrar todas as palavras
            // que tenham somente 6 caracteres no campo Lenght.
            // Se caso não encontrar o objeto, ele simplesmente não faz nada.
            List<string> list4 = list2.FindAll(x => x.Length == 6);
            Console.WriteLine("~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=");
            foreach (string obj in list4) {
                Console.WriteLine(obj);
            }

            // Abaixo removido a palavra inteira da lista dos que começam com J e F.
            list2.RemoveAll(x => x[0] == 'J');
            list2.RemoveAll(x => x[0] == 'F');
            Console.WriteLine("~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            // Abaixo irá remover a palavra que está na posição 1 do index.
            list2.RemoveAt(1);
            Console.WriteLine("~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            // Irá remover um range começando do index 2, e os próximos 2 valores
            // no contador.
            list2.RemoveRange(2, 2);
            Console.WriteLine("~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            /*
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            //Console.WriteLine(contLinha);
            Console.WriteLine("USANDO FOR TRADICIONAL");            
            for (int i = 0; i < contLinha; i++) {
                Console.Write($"{list2[i]} ");
            }

            */
        }

        // Classes abaixo criadas com o mesmo objetivo das expressões LAMBDA acima.
        static bool Test(string s) {
            return s[0] == 'D';
        }

        static bool Test2(string b) {
            return b[0] == 'F';
        }
    }
}

