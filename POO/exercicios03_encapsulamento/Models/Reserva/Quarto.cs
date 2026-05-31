using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Reserva
{
    public class Quarto
    {
        private int valorDiaria;

        public int Numero { get; }
        public int ValorDiaria
        {
            get => valorDiaria; set
            {
                if (value > 0)
                {
                    valorDiaria = value;
                }
                else
                {
                    Console.WriteLine("Erro: O valor da diária deve ser maior que zero.");
                }
            }
        }

        public Quarto(int numero)
        {
            Numero = numero;
        }

    }
}