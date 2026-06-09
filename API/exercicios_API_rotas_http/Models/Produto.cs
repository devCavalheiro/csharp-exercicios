namespace exercicios_API_rotas.Models;

public class Produto
{
    private static int proximoId = 1;

    public int Id { get; private set; }
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Produto(string? nome, decimal preco, int quantidadeEmEstoque)
    {
        Id = proximoId++;
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }
}