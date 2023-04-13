// See https://aka.ms/new-console-template for more information
/*
string[] nome = new string[4];

nome[0] = "Juan";
nome[1] = "Cleber";
nome[2] = "Faria";
nome[3] = "Alves";

// string diretorios = @"D:\";
string[] arquivos = Directory.GetDirectories(@"D:\");

int teste2 = 10;
double teste3 = 10.3;

Console.WriteLine(teste3.GetType());
Console.WriteLine(teste2);


// string[] diretorios = Directory.GetDirectories("D:\\", "*", SearchOption.TopDirectoryOnly);

using System.Collections.Generic;

string[] diretorios = Directory.GetDirectories("D:\\", "*", SearchOption.TopDirectoryOnly).Where(d => !d.StartsWith("D:\\FTP") && !d.StartsWith("D:\\Unimake_") && !d.StartsWith("D:\\_Instaladores") && !d.StartsWith("D:\\System") && !d.StartsWith("D:\\$R") && !d.StartsWith("D:\\Sua_")).ToArray();

string[] diretorios2 = Directory.GetFiles("D:\\IMPERIO", "*", SearchOption.TopDirectoryOnly);

foreach (string listar in diretorios2)
{
    Console.WriteLine(listar);
}


using System.Xml.Serialization;

string caminho = @"D:\Fenicia\profile_users\kv1\nfe\V2\EnvioLote\teste.txt";

string[] soArquivo = caminho.Split('\\');

Console.WriteLine(soArquivo[soArquivo.Length -1]);

using System.Collections.Generic;

List<int> teste = new List<int>();

teste.Add(10);
teste.Add(20);
teste.Add(30);

int ultimo = teste[teste.Count - 1];

Console.WriteLine(ultimo);


string[] arquivos = Directory.GetDirectories(@"D:\Fenicia\\profile_users", "*", SearchOption.TopDirectoryOnly);

foreach (string listar in arquivos)
{
    Console.WriteLine(listar);
}

int contador = -10;

contador--;

Console.WriteLine(contador);

 */

int val1 = 5;
int val2 = 2;

int soma = val1 + val2;

if (soma > 10)
{
    Console.WriteLine("valor da soma e maior que 10");
}
else
{
    Console.WriteLine("valor da soma é menor do que 10");
}

