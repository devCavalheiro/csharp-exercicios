using exercicios_API_rotas.Models;
using Microsoft.AspNetCore.Mvc;

namespace exercicios_API_rotas.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new();

    [HttpGet]
    public IActionResult ObterTodosFilmes()
    {
        return Ok(filmes);
    }

    [HttpPost]
    public IActionResult CadastrarFilme(Filme novoFilme)
    {
        filmes.Add(novoFilme);

        return Created();
    }

    [HttpPut("{id}")]
    public IActionResult EditarFilme(int id, Filme filmeAtualizado)
    {
        var filmeASerEditado = filmes.FirstOrDefault(f => f.Id == id);

        if (filmeASerEditado == null)
            return NotFound();

        filmeASerEditado.Nome = filmeAtualizado.Nome;
        filmeASerEditado.Duracao = filmeAtualizado.Duracao;
        filmeASerEditado.Ano = filmeAtualizado.Ano;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult ExcluirFilmePorId(int id)
    {
        var filmeASerExcluido = filmes.FirstOrDefault(f => f.Id == id);

        if (filmeASerExcluido == null)
            return NotFound();

        filmes.Remove(filmeASerExcluido);

        return NoContent();
    }
}