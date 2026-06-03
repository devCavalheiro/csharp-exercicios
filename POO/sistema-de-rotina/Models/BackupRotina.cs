using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_de_rotina.Interfaces;

namespace sistema_de_rotina.Models
{
    public class BackupRotina : RotinaBase
    {
        public BackupRotina(string nome, DateTime dataCriacao) : base(nome, dataCriacao)
        {
        }

        public override void Executar()
        {
            throw new NotImplementedException();
        }
    }
}