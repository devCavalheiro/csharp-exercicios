using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Certificados
{
    public class Certificado
    {
        public void ExibirMensagem( Profissao Profissao)
        {
            Console.WriteLine($"Certificado emitido para: {Profissao.Titulo}");
        }
    }
}