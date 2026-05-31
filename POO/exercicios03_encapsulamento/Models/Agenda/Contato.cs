using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Agenda
{
    public class Contato
    {

        public string Nome { get; }
        public string Telefone { get; }

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}