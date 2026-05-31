using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Cursos
{
    public class Instrutor
    {
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        
        public Instrutor(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }
    }
}