using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Matricula
{
    public class Estudante
    {
        public string Nome { get; }

        public Estudante(string nome)
        {
            Nome = nome;
        }
    }
}