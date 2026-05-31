using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Servicos
{
    public class Consultoria : IServico
    {
        public string Servico { get; }
        public Funcionario Funcionario { get; }

        public Consultoria(string servico, Funcionario funcionario)
        {
            Servico = servico;
            Funcionario = funcionario;
        }

        public void ExecutarServico()
        {
            Console.WriteLine($"Executando serviço de consultoria: {Servico}");
            Console.WriteLine($"Consultor responsável: {Funcionario.Nome} - Departamento: {Funcionario.Departamento}");
        }
    }
}