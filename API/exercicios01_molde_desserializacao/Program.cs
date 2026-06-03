using System.Text.Json;
using exercicios01_molde_desserializacao.Models;

var client = new HttpClient();

Console.Clear();

try
{
    string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
    var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;

    Console.WriteLine($"Filmes na API:");
    foreach (var f in filmes)
    {
        f.ExibirDetalhesDoFilme();
        Console.WriteLine();
    }
    Console.WriteLine($"Quantidade de filmes na API: {filmes.Count()}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex}");
}