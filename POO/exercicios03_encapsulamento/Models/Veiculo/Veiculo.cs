using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Veiculo
{
    public class Veiculo
    {
        public string Placa { get; }
        public double VelocidadeAtual { get; private set; }

        public Veiculo(string placa)
        {
            Placa = placa;
        }

        public void AtualizarVelocidade(double novaVelocidade) => VelocidadeAtual = novaVelocidade;
    }
}