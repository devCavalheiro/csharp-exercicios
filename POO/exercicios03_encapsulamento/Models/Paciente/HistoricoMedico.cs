using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Paciente
{
    public class HistoricoMedico
    {
        public Paciente Paciente { get; }
        public string CodigoProntuario { get; }

        public HistoricoMedico(string codigoProntuario, Paciente paciente)
        {
            CodigoProntuario = codigoProntuario;
            Paciente = paciente;
        }

        public void ExibirCodigo()
        {
            Console.WriteLine($"Paciente: {Paciente.Nome}, {Paciente.Idade} anos");
            Console.WriteLine($"Código do prontuário: {CodigoProntuario}");
        }
    }
}