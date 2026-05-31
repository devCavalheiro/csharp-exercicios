using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Projeto
{
    public class Projeto
    {
        public string Nome { get; }
        private List<string> tarefas = new();
        public int QuantidadeTarefas { get => tarefas.Count; }

        public Projeto(string nome)
        {
            Nome = nome;
        }

        public void AdicionarTarefa(string tarefa)
        {
            if (string.IsNullOrWhiteSpace(tarefa))
            {
                Console.WriteLine($"'Tarefa inválida'");
            }
            else if (tarefas.Contains(tarefa))
            {
                Console.WriteLine($"'Tarefa {tarefa} já existe'");
            }
            else
            {
                tarefas.Add(tarefa);
                Console.WriteLine($"Tarefa {tarefa} adicionada à {Nome}");
            }
        }
        public void ExibirTarefas()
        {
            Console.WriteLine($"\nProjeto: {Nome}");
            Console.WriteLine($"Tarefas:");

            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"- {tarefa}");
            }

            Console.WriteLine($"Total: {QuantidadeTarefas} tarefas");

        }
    }
}