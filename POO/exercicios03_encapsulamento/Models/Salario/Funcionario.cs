using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Salario
{
    public class Funcionario
    {
        private double salario;

        public string Nome { get; }
        public double Salario { get => salario; }

        public Funcionario(string nome, double salarioInicial)
        {
            Nome = nome;
            salario = salarioInicial;
        }

        public void ReajustarSalario(double novoValor)
        {
            if (novoValor > salario)
            {
                salario = novoValor;
            }
            else
            {
                Console.WriteLine("Erro: O novo salário deve ser maior que o atual.");
            }
        }
    }
}