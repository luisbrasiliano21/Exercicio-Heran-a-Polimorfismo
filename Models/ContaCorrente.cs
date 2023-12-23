using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta , decimal SaldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = SaldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal Saldo;


        public void Sacar(decimal Valor)
        
        {
            if(Saldo>=Valor){
            Saldo -= Valor;
            Console.WriteLine("Saque realizado com sucesso !");

            }
            else 
            {
                Console.WriteLine("Saque não pode ser realizado");
            }
            
        }
        public void ExibirSaldo()
            
            {
                Console.WriteLine("Seu Saldo é de: " + Saldo);
            }

    }
}