using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_rotina.Models
{
    public class DiagnosticoSistema : RotinaBase
    {
        public DiagnosticoSistema(string nome, DateTime dataCriacao) : base(nome, dataCriacao) { }

        public override void Executar()
        {
            throw new NotImplementedException();
        }
    }
}