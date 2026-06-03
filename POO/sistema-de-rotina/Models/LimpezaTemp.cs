using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_rotina.Models
{
    public class LimpezaTemp : RotinaBase
    {
        private Random random = new();

        public int ArquivosRemovidos { get; }

        public LimpezaTemp(string nome, DateTime dataCriacao) : base(nome, dataCriacao)
        {
            ArquivosRemovidos = random.Next(0, 350);
        }

        public override void Executar()
        {
            Console.WriteLine($"Executando");
            Console.WriteLine($"Quantidade de arquivos temporários removidos: {ArquivosRemovidos}");
        }
    }
}