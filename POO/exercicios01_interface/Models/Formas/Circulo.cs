using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_poo_cs_interface_1.Models.Formas
{
    public class Circulo : IForma
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }
        
        public double CalcularArea() => Math.PI * Math.Pow(Raio, 2);
        public double CalcularPerimetro() => 2 * Math.PI * Raio;
    }
}