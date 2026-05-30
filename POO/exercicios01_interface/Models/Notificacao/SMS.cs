using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_poo_cs_interface_1.Models.Notificacao
{
    public class SMS : INotificavel
    {
        public string Numero { get; set; }

        public SMS(string numero)
        {
            Numero = numero;
        }

        public void EnviarNotificacao() => Console.WriteLine($"Enviando SMS para {Numero}");
    }
}