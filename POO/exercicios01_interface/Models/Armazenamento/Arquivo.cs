using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_poo_cs_interface_1.Models.Armazenamento
{
    public class Arquivo : IArmazenavel
    {
        public string Nome { get; set; }

        public Arquivo(string nome)
        {
            Nome = nome;
        }
    
        public void Recuperar() => Console.WriteLine($"Recuperando arquivo '{Nome}");
        public void Salvar() => Console.WriteLine($"Salvando arquivo '{Nome}'");
    }
}