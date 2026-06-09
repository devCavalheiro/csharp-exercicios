using exercicios_API_rotas.Models;
using Microsoft.AspNetCore.Mvc;

namespace exercicios_API_rotas.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    private static List<Produto> produtos = new()
    {
        new("RTX 5060", 2100.00m, 30),
        new("Pastel", 12.99m, 1),
        new("RTX 4060", 2300.99m, 24),
        new("RX 7600", 1500.99m, 50),
        new("RX 9070", 4900.00m, 14),

        new("Xis", 25.99m, 1),
    };

    [HttpGet]
    public IActionResult ObterListaProdutos()
    {
        return Ok(produtos);
    }

    [HttpGet("maiores-que-cem")]
    public IActionResult ObterProdutosMaioresQueCem()
    {
        List<Produto> produtosMaioresQueCem = new();

        foreach (var p in produtos)
        {
            if (p.Preco > 100)
            {
                produtosMaioresQueCem.Add(p);
            }
        }

        return Ok(produtosMaioresQueCem);
    }

    [HttpGet("{id}")]
    public IActionResult ObterProdutoPorId(int id)
    {
        var produtoProcurado = produtos.FirstOrDefault(p => p.Id == id);

        if (produtoProcurado == null)
            return NotFound();

        return Ok(produtoProcurado);
    }

    [HttpGet("pesquisa")]
    public IActionResult ObterProdutoPorNome(string nome)
    {
        var produtoProcurado = produtos.Where(p => p.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));

        return Ok(produtoProcurado);
    }


    [HttpPost]
    public IActionResult CadastrarProduto(Produto novoProduto)
    {
        produtos.Add(novoProduto);

        return CreatedAtAction(
            nameof(ObterProdutoPorId),
            new { id = novoProduto.Id },
        novoProduto);
    }

    [HttpPut("{id}")]
    public IActionResult AlterarNomeProduto(int id, Produto produtoAtualizado)
    {
        var produtoASerAlterado = produtos.FirstOrDefault(p => p.Id == id);

        if (produtoASerAlterado == null)
            return NotFound();

        produtoASerAlterado.Nome = produtoAtualizado.Nome;
        produtoASerAlterado.Preco = produtoAtualizado.Preco;
        produtoASerAlterado.QuantidadeEmEstoque = produtoAtualizado.QuantidadeEmEstoque;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarProdutoPorId(int id)
    {
        var produtoASerDeletado = produtos.FirstOrDefault(p => p.Id == id);

        if (produtoASerDeletado == null)
            return NotFound();

        produtos.Remove(produtoASerDeletado);

        return NoContent();
    }

    [HttpDelete]
    public IActionResult DeletarTodosProdutos()
    {
        produtos.Clear();

        return NoContent();
    }
}