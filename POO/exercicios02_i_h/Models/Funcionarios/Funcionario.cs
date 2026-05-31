using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; }
        public string Cargo { get;  }

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"{GetType().Name} {Nome} - Cargo: {Cargo}");
        }
    }
}