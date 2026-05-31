using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Saque
{
    internal class SegurancaConta
    {
        public bool ValidarSaque(double valor)
        {
            return valor <= 1000;
        }
    }
}