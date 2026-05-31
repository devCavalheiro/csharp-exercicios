using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Clientes
{
    public class ClienteVIP : Pessoa
    {
        public string NivelFidelidade { get; set; }
        public string CodigoVIP { get; set; }

        public ClienteVIP(string nome, int idade, string nivelFidelidade, string codigoVIP) : base(nome, idade)
        {
            NivelFidelidade = nivelFidelidade;
            CodigoVIP = codigoVIP;
        }

        public void SaudacaoVIP()
        {
            Console.WriteLine($"Bem vindo, cliente VIP: {Nome}");
            Console.WriteLine($"Idade: {Idade} anos");
            Console.WriteLine($"Nível de Fidelidade: {NivelFidelidade}");
            Console.WriteLine($"Código VIP: {CodigoVIP}");
        }
    }
}