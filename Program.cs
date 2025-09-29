using dio_dotnet_poo.Models;
using System.Globalization;



try
{
    string[] linhas = File.ReadAllLines("Files/arquivoLeitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma excessão genérica. {ex.Message}");
}