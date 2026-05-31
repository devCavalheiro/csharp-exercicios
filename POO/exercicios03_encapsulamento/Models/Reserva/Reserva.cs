using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Reserva
{
    public class Reserva
    {
        private int diarias;

        public Hospede Hospede { get; }
        public Quarto Quarto { get; }
        public decimal ValorTotal { get => Quarto.ValorDiaria * diarias; }

        public Reserva(Hospede hospede, Quarto quarto, int diarias)
        {
            if (diarias <= 0) { throw new ArgumentException("O número de diárias deve ser maior que zero."); }
            Hospede = hospede;
            Quarto = quarto;
            this.diarias = diarias;
        }

        public void MostrarReserva()
        {
            Console.WriteLine($"Reserva para: {Hospede.Nome}");
            Console.WriteLine($"Quarto: {Quarto.Numero}");
            Console.WriteLine($"Valor total: R$ {ValorTotal:F2}");
        }
    }
}