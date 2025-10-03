using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dotnet_poo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }
        public int NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("O valor desejado é maior que o saldo disponível!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponível é: " + Saldo);
        }
    }
}