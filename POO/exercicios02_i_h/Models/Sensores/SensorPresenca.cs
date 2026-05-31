using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Sensores
{
    public class SensorPresenca : ISensor
    {
        public void Ativar()
        {
            Console.WriteLine("Sensor de presença ativado.");
        }

        public void Desativar()
        {
            Console.WriteLine("Sensor de presença desativado.");
        }
    }
}