using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, Meu nome é {Nome} e tenho {Idade} anos. \r\n Nota: {Nota}");
        }
        
        

    }
}