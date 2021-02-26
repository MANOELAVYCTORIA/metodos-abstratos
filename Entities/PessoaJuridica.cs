using System;
using exercicio_de_fixação__Métodos_abstratos_.Entities;

namespace exercicio_de_fixação__Métodos_abstratos_.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios):base(nome, rendaAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public override double Imposto()
        {
            if(NumeroDeFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }

    }
}
