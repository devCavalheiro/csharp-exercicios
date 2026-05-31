using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Sensores
{
    public interface ISensor
    {
        void Ativar();
        void Desativar();
    }
}