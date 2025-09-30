using dio_dotnet_poo.Models;
using System.Globalization;

(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Marcos", "Marques", 1.67M);

ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Leonardo", "Buta", 1.80M);

var outroExemploTuplaCreate = Tuple.Create(3, "João", "Neves", 1.74M);


Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");