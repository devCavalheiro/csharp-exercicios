namespace exercicios04_polimorfismo.Models.Galeria_Online;

public class Midia
{
    public string Nome { get; protected set; }

    public Midia(string nome)
    {
        Nome = nome;
    }

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Midia: {Nome}");
    }
}
