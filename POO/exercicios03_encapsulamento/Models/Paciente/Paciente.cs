using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Paciente
{
    public class Paciente
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        
        public Paciente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}