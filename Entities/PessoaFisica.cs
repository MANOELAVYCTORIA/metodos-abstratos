using System;
using exercicio_de_fixação__Métodos_abstratos_.Entities;

namespace exercicio_de_fixação__Métodos_abstratos_.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude):base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double Imposto()
        {
            if(RendaAnual < 20000.00)
            {
                return RendaAnual * 0.15 - GastosComSaude * 0.5;
              
            }
            else 
            {
                return RendaAnual * 0.25 - GastosComSaude * 0.5;
            }

        }
    }
}
