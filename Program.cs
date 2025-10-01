using dio_dotnet_poo.Models;
using System.Globalization;

int numero = 20;
bool ehPar = false;

ehPar = numero % 2 == 0;
Console.WriteLine($"O numero {numero} é: " + (ehPar ? "par" : "ímpar") + ".");


// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O numero {numero} é par!");
// }
// else
// {
//     Console.WriteLine($"O numero {numero} é ímpar!");
// }