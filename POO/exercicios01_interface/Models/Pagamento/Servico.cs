using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_poo_cs_interface_1.Models.Pagamento
{
    public class Servico : IPagavel
    {
        public string Nome { get; set; }
        public decimal TaxaHoraria { get; set; }
        public int HorasTrabalhadas { get; set; }

        public Servico(string nome, decimal taxaHoraria, int horasTrabalhadas)
        {
            Nome = nome;
            TaxaHoraria = taxaHoraria;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public decimal CalcularPagamento() => TaxaHoraria * HorasTrabalhadas;
    }
}