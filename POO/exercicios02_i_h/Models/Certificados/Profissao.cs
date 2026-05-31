using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Certificados
{
    public abstract class Profissao
    {
        public string Titulo { get; }

        protected Profissao(string titulo)
        {
            Titulo = titulo;
        }
    }
}