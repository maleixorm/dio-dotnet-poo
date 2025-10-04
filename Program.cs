using dio_dotnet_poo.Models;
using System.Globalization;

Pessoa p1 = new Pessoa("Marcos", "Marques", 37);

p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(300);
c1.ExibirSaldo();

Aluno a1 = new Aluno();
a1.Nome = "Leonardo";
a1.Sobrenome = "Buta";
a1.Idade = 30;
a1.Nota = 9;
a1.Apresentar();
Console.WriteLine($"A nota de {a1.Nome} é: {a1.Nota}");