using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_poo_cs_interface_1.Models.Armazenamento
{
    public class BancoDeDados : IArmazenavel
    {
        public string NomeBanco { get; set; }

        public BancoDeDados(string nomeBanco)
        {
            NomeBanco = nomeBanco;
        }

        public void Recuperar() => Console.WriteLine($"Recuperando dados do banco de dados '{NomeBanco}'");
        public void Salvar() => Console.WriteLine($"Salvando dados no banco de dados '{NomeBanco}'");
    }
}