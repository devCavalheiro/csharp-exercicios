using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Funcionarios
{
    public class Freelancer : Funcionario
    {
        public decimal ValorProjeto { get;}

        public Freelancer(string nome, string cargo, decimal valorProjeto) : base(nome, cargo)
        {
            ValorProjeto = valorProjeto;
        }

        override public void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Valor do Projeto: R$ {ValorProjeto:F2}");
        }
    }
}