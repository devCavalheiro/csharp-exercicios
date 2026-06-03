using System.Text.Json;
using projeto_consumindo_API.Models;

using var client = new HttpClient();

Console.Clear();

client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0");

try
{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

    
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex}");
}