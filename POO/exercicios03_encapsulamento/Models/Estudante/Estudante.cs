using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios03_encapsulamento.Models.Estudante
{
    public class Estudante
    {
        public string Nome { get; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Media { get => (Nota1 + Nota2) / 2; }
        public string Situacao { get => Media >= 6 ? "Aprovado" : "Reprovado"; }

        public Estudante(string nome)
        {
            Nome = nome;
        }
    }
}