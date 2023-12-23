using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
   

namespace ExemploPoo.Models
{
    public class Professor : Pessoa
    {
       public decimal Salario { get; set; }



        public override void Apresentar()
        {
             Console.WriteLine($"olá, Meu nome é {Nome} sou Professor e Tenho {Idade} anos. \r\n Salário: {Salario.ToString("C")}");
        }
    
    }
}