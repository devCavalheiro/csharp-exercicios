using System.Text.Json.Serialization;

namespace exercicios01_molde_desserializacao.Models;

public class Filme
{
    [JsonPropertyName("title")]
    public string? Nome { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("imDbRating")]
    public string? AvaliacaoIMDB { get; set; }

    public void ExibirDetalhesDoFilme()
    {
        Console.WriteLine($"Filme: {Nome}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Avaliação IMDB: {AvaliacaoIMDB}");
    }
}
