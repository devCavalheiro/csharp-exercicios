namespace exercicios_API_rotas.Models;

public class Filme
{
    private static int proximoId = 1;

    public int Id { get; private set; }
    public string Nome { get; set; }
    public TimeSpan Duracao { get; set; }
    public int Ano { get; set; }

    public Filme(string nome, TimeSpan duracao, int ano)
    {
        Id = proximoId++;
        Nome = nome;
        Duracao = duracao;
        Ano = ano;
    }

}