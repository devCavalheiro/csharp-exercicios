using exercicios_API_rotas.Models;
using Microsoft.AspNetCore.Mvc;

namespace exercicios_API_rotas.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private static List<Cliente> clientes = new()
    {
        new("Gabriel"),
        new("Fulano"),
        new("Siclano"),
        new("Beltrano")
    };

    [HttpGet]
    public IActionResult ObterTodosClientes()
    {
        return Ok(clientes);
    }

    [HttpPost]
    public IActionResult CadastrarCliente(Cliente novoCliente)
    {
        clientes.Add(novoCliente);

        return Created();
    }

    [HttpPut("{id}")]
    public IActionResult EditarCliente(int id, Cliente clienteAtualizado)
    {
        var clientASerEditado = clientes.FirstOrDefault(c => c.Id == id);

        if (clientASerEditado == null)
            return NotFound();

        clientASerEditado.Nome = clienteAtualizado.Nome;

        return NoContent();
    }

    [HttpDelete]
    public IActionResult ExcluirTodosClientes()
    {
        clientes.Clear();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult ExcluirClientePorId(int id)
    {
        var clienteASerExcluido = clientes.FirstOrDefault(c => c.Id == id);

        if (clienteASerExcluido == null)
            return NotFound();

        clientes.Remove(clienteASerExcluido);

        return NoContent();
    }
}