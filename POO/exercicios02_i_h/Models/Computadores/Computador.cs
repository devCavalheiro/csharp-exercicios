using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Computadores
{
    public class Computador
    {
        public Processador Processador { get; }
        public PlacaMae PlacaMae { get; }

        public Computador(Processador processador, PlacaMae placaMae)
        {
            Processador = processador;
            PlacaMae = placaMae;
        }

        public void ExibirConfiguracao()
        {
            Console.WriteLine($"Computador com Processador: {Processador.Marca} - {Processador.Modelo} e Placa Mãe: {PlacaMae.Fabricante} - {PlacaMae.Socket}");
        }
    }
}