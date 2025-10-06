using dio_dotnet_poo.Interfaces;
using dio_dotnet_poo.Models;
using System.Globalization;

Computador c = new Computador();
Console.WriteLine(c.ToString());

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));
Console.WriteLine(calc.Somar(2, 5));