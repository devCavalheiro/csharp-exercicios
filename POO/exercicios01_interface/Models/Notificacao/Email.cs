using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios_poo_cs_interface_1.Models.Notificacao
{
    public class Email : INotificavel
    {
        public string Destinatario { get; set; }

        public Email(string destinatario)
        {
            Destinatario = destinatario;
        }
        
        public void EnviarNotificacao() => Console.WriteLine($"Enviando Email para {Destinatario}");
    }
}