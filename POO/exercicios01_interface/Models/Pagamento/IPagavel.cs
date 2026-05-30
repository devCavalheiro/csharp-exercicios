using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_poo_cs_interface_1.Models.Pagamento
{
    public interface IPagavel
    {
        decimal CalcularPagamento();
    }
}