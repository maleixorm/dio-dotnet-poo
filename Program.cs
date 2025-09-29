using dio_dotnet_poo.Models;
using System.Globalization;

string[] linhas = File.ReadAllLines("Files/arquivoLeitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}