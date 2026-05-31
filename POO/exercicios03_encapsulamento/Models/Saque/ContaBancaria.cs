using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Saque
{
    public class ContaBancaria
    {
        private double saldo;

        private string Titular { get; }
        public double Saldo { get => saldo; }

        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            saldo = saldoInicial;
        }

        public void Sacar(double valor)
        {
            SegurancaConta segurancaConta = new();

            if (segurancaConta.ValidarSaque(valor))
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saque negado pela política de segurança.");
            }
        }
    }
}