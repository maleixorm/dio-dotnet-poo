using dio_dotnet_poo.Models;
using System.Globalization;

Pessoa p1 = new Pessoa("Marcos", "Marques", 37);

p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(300);
c1.ExibirSaldo();