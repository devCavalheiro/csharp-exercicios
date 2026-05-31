namespace exercicios04_polimorfismo.Models.Notificacoes_do_Sistema;

public class SmsNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}
