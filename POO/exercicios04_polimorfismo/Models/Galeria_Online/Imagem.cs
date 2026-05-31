namespace exercicios04_polimorfismo.Models.Galeria_Online;

public class Imagem : Midia
{
    public string Resolucao { get; }

    public Imagem(string nome, string resolucao) : base(nome)
    {
        Resolucao = resolucao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Imagem: {Nome} - Resolução: {Resolucao}");
    }
}
