using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Computadores
{
    public class Processador
    {
        public string Marca { get; }
        public string Modelo { get; }
        
        public Processador(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
    }
}