namespace exercicios04_polimorfismo.Models.Avaliacao_de_Conteudos;

public class MaterialComplementar : Conteudo
{
    public int NumeroPaginas { get; set; }

    public MaterialComplementar(string titulo, int numeroPaginas) : base(titulo)
    {
        NumeroPaginas = numeroPaginas;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Páginas: {NumeroPaginas}");
    }
}
