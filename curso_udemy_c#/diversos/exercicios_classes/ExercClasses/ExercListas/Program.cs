using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercListas {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.Write("Quantos empregados serão registrados? ");
            int quantEmp = int.Parse(Console.ReadLine());

            List<Empregados> list = new List<Empregados>();

            for (int i = 1; i <= quantEmp; i++) {
                Console.WriteLine($"Empregado #{i}:  ");
                Console.Write("Id:  ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double sal = double.Parse(Console.ReadLine(), CI);
                list.Add(new Empregados(id, nome, sal));
                Console.WriteLine();
            }

            Console.Write("Informar o ID do empregado que terá aumento: ");
            int funcID = int.Parse(Console.ReadLine());

            Empregados emp = list.Find(x => x.Id == funcID);
            if (emp != null) {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CI);
                emp.AumentarSalario(porcentagem);
            }
            else {
                Console.WriteLine("Esse ID não existe! Tente novamente");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de Empregados Atualizada: ");
            foreach (Empregados obj in list) {
                Console.WriteLine(obj);
            }


            

            /*
            Console.WriteLine("Os IDs São:");
            foreach(int id in listID) {
                Console.WriteLine(id);
            }

            Console.WriteLine("Os Nomes São: ");
            foreach(string nome in listNome) {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Os Salários São: ");
            foreach(double salario in listSalario) {
                Console.WriteLine(salario);
            }

            */

        }
    }
}
