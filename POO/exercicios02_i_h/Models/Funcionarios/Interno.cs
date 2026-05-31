using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Funcionarios
{
    public class Interno : Funcionario
    {
        public decimal Salario { get;}

        public Interno(string nome, string cargo, decimal salario) : base(nome, cargo)
        {
            Salario = salario;
        }

        override public void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Salário: R$ {Salario:F2}");
        }
    }
}