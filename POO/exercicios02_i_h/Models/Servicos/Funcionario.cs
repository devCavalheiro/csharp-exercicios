using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Servicos
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
        
        public Funcionario(string nome, string departamento)
        {
            Nome = nome;
            Departamento = departamento;
        }
    }
}