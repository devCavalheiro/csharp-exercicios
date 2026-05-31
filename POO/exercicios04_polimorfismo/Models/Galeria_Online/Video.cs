namespace exercicios04_polimorfismo.Models.Galeria_Online;

public class Video : Midia
{
    public int Duracao { get; set; }

    public Video(string nome, int duracao) : base(nome)
    {
        Duracao = duracao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Vídeo: {Nome} - Duração: {Duracao} minutos");
    }
}
