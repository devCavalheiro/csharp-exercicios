namespace exercicios04_polimorfismo.Models.Avaliacao_de_Conteudos;

public class Conteudo
{
    public string Titulo { get; }

    public Conteudo(string titulo)
    {
        Titulo = titulo;
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Título: {Titulo}");
    }
}
