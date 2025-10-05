using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dotnet_poo.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Eu sou o {Nome} e minha nota é {Nota}");
        }
    }
}