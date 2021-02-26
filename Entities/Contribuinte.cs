using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_de_fixação__Métodos_abstratos_.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double  RendaAnual{ get; set; }

        public Contribuinte()
        {

        }

        public Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
        
          
        
    }
}
