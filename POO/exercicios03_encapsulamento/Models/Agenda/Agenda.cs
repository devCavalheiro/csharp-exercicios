using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Agenda
{
    public class Agenda
    {
        public string Proprietario { get; }
        private readonly List<Contato> contatos = new();

        public Agenda(string proprietario)
        {
            Proprietario = proprietario;
        }

        public bool AdicionarContato(Contato contato)
        {
            if (!contatos.Any(c => c.Nome == contato.Nome))
            {
                contatos.Add(contato);
                return true;
            }
            else
            {
                Console.WriteLine($"Contato {contato.Nome} já está na agenda.");
                return false;
            }
        }
        public void ListarContatos()
        {
            Console.WriteLine($"Agenda de: {Proprietario}");
            Console.WriteLine("Contatos:");

            foreach (var contato in contatos)
            {
                Console.WriteLine($"- {contato.Nome} | {contato.Telefone}");
            }

            Console.WriteLine($"Quantidade de contatos: {contatos.Count}");
        }
    }
}