namespace exercicios04_polimorfismo.Models.Notificacoes_do_Sistema;

public class EmailNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando E-MAIL: {mensagem}");
    }
}
