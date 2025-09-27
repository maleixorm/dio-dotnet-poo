using dio_dotnet_poo.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P2"));

DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());







Pessoa p1 = new Pessoa("Marcos", "Marques", 37);
Pessoa p2 = new Pessoa("Leonardo", "Buta", 30);
Pessoa p3 = new Pessoa("Eduardo", "Neves", 22);

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();