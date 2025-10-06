using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dotnet_poo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Eu sou o {Nome} e meu salário é {Salario.ToString("C")}");
        }
    }
}