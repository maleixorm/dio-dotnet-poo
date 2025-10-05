using dio_dotnet_poo.Models;
using System.Globalization;

Corrente c1 = new Corrente();
c1.Creditar(500);
c1.ExibirSaldo();

Pessoa p1 = new Pessoa("Marcos");
Aluno a1 = new Aluno("Eduardo");
a1.Apresentar();