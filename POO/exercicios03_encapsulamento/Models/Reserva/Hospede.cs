using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Reserva
{
    public class Hospede
    {
        public string Nome { get; }

        public Hospede(string nome)
        {
            Nome = nome;
        }
    }
}