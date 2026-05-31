using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Sensores
{
    public class SensorTemperatura : ISensor
    {
        public void Ativar()
        {
            Console.WriteLine("Sensor de temperatura ativado.");
        }

        public void Desativar()
        {
            Console.WriteLine("Sensor de temperatura desativado.");
        }
    }
}