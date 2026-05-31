using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Matricula
{
    public class Curso
    {
        private List<Estudante> matriculas = new();

        public string Nome { get; }
        public int VagasTotais { get; private set; }
        public int VagasDisponiveis { get => VagasTotais - matriculas.Count; }

        public Curso(string nome, int vagasTotais)
        {
            Nome = nome;
            VagasTotais = vagasTotais;
        }

        public bool Matricular(Estudante estudante)
        {
            if (matriculas.Count < VagasTotais)
            {
                matriculas.Add(estudante);
                Console.WriteLine("Estudante matriculado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("Erro: Não há vagas disponíveis para este curso.");
                return false;
            }
        }
        public void ListarMatriculados()
        {
            Console.WriteLine($"Estudantes matriculados em {Nome}");

            foreach (var estudante in matriculas)
            {
                Console.WriteLine($"- {estudante.Nome}");
            }

            Console.WriteLine($"Vagas disponíveis: {VagasDisponiveis}");
        }
    }
}