using System;
using exercicio_de_fixação__Métodos_abstratos_.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio_de_fixação__Métodos_abstratos_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();

            Console.WriteLine("Entre com a quantidade de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Dados do contribuinte #{i}: ");
                Console.Write("Pessoa Física ou Jurídica (f/j)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaanual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'f')
                {
                    Console.Write("Gastos com saúde: ");
                    double gastos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(nome, rendaanual, gastos));

                }
                else
                {
                    Console.Write("Número de funcionarios: ");
                    int funcionarios = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(nome, rendaanual, funcionarios));
                }  
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXAS PAGAS");
            foreach(Contribuinte func in list)
            {
                double imposto = func.Imposto();
                Console.WriteLine(func.Nome + ": $" + imposto.ToString("F2", CultureInfo.InvariantCulture));
                sum += imposto;
            }

            

            Console.WriteLine();
            
                Console.WriteLine("TOTAL DE TAXAS: $" + sum.ToString("f2",CultureInfo.InvariantCulture) );
            
            
        }
    }
}
