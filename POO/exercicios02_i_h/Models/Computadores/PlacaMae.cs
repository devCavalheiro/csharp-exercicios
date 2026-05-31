using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Computadores
{
    public class PlacaMae
    {
        public string Fabricante { get; }
        public string Socket { get; }

        public PlacaMae(string fabricante, string socket)
        {
            Fabricante = fabricante;
            Socket = socket;
        }
    }
}