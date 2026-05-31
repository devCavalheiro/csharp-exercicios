using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Pagamentos
{
    public class PagamentoBoleto : Pessoa, IPagamento
    {
        public PagamentoBoleto(string nome, string email) : base(nome, email) { }

        public void ProcessarPagamento() => Console.WriteLine($"Processando pagamento via boleto para: {Nome} - {Email}");
    }
}