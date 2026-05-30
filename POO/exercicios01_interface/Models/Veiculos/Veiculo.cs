using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_poo_cs_interface_1.Models.Veiculos
{
    public class Veiculo : IVoavel, IPilotavel
    {
        public void Pilotar() => Console.WriteLine("Pilotando veículo");
        public void Voar() => Console.WriteLine("Veículo está voando");
    }
}