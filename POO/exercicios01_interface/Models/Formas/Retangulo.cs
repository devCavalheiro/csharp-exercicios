using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_poo_cs_interface_1.Models.Formas
{
    public class Retangulo : IForma
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }
        
        public double CalcularArea() => Altura * Largura;
        public double CalcularPerimetro() => 2 * (Altura + Largura);
    }
}