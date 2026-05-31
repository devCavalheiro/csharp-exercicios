using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Pagamentos
{
    public class PagamentoCredito : Pessoa, IPagamento
    {
        public PagamentoCredito(string nome, string email) : base(nome, email) { }

        public void ProcessarPagamento() => Console.WriteLine($"Processando pagamento com cartão de crédito para: {Nome} - {Email}");
    }
}