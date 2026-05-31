namespace exercicios04_polimorfismo.Models.Notificacoes_do_Sistema;

public class PushNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando PUSH: {mensagem}");
    }
}
