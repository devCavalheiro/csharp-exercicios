using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Pagamentos
{
    public class Pessoa
    {
        public string Nome { get; }
        public string Email { get; }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}