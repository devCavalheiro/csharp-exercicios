namespace exercicios04_polimorfismo.Models.Avaliacao_de_Conteudos;

public class AulaGravada : Conteudo
{
    public int Duracao { get; set; }

    public AulaGravada(string titulo, int duracao) : base(titulo)
    {
        Duracao = duracao;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Duração: {Duracao} min");
    }
}
