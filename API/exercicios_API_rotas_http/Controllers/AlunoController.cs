using exercicios_API_rotas.Models;
using Microsoft.AspNetCore.Mvc;

namespace exercicios_API_rotas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private static List<Aluno> alunos = new()
        {
            new("Gabriel", 8.5, 9.9),
            new("Fulano", 4.7, 3.6),
            new("Siclano", 10, 9.8)
        };

        [HttpGet]
        public IActionResult ObterTodosAlunos()
        {
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public IActionResult ObterAlunoPorId(int id)
        {
            var alunoProcurado = alunos.FirstOrDefault(a => a.Id == id);

            if (alunoProcurado == null)
                return NotFound();

            return Ok(alunoProcurado);
        }

        [HttpPost]
        public IActionResult CadastrarAluno(Aluno novoAluno)
        {
            alunos.Add(novoAluno);

            return CreatedAtAction(
                nameof(ObterAlunoPorId),
                new { id = novoAluno.Id },
                novoAluno);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarDadosAluno(int id, Aluno alunoAtualizado)
        {
            var alunoASerAtualizado = alunos.FirstOrDefault(a => a.Id == id);

            if (alunoASerAtualizado == null)
                return NotFound();

            alunoASerAtualizado.Nome = alunoAtualizado.Nome;
            alunoASerAtualizado.NotaUm = alunoAtualizado.NotaUm;
            alunoASerAtualizado.NotaDois = alunoAtualizado.NotaDois;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverAlunoPorId(int id)
        {
            var alunoASerRemovido = alunos.FirstOrDefault(a => a.Id == id);

            if (alunoASerRemovido == null)
                return NotFound();

            alunos.Remove(alunoASerRemovido);

            return NoContent();
        }

        [HttpDelete]
        public IActionResult RemoverTodosAlunos()
        {
            alunos.Clear();

            return NoContent();
        }
    }
}