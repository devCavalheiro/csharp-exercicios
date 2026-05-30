using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_poo_cs_interface_1.Models.Pagamento
{
    public class Produto : IPagavel
    {
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            PrecoUnitario = preco;
            Quantidade = quantidade;
        }

        public decimal CalcularPagamento() => PrecoUnitario * Quantidade;
    }
}