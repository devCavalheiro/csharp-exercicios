using sistema_de_rotina.Interfaces;

namespace sistema_de_rotina.Models;

public abstract class RotinaBase : IRotina
{
    public string Nome { get; }
    public DateTime DataCriacao { get; }

    protected RotinaBase(string nome, DateTime dataCriacao)
    {
        Nome = nome;
        DataCriacao = dataCriacao;
    }

    public abstract void Executar();
    public virtual void ExibirCabecalho() { }

    public string ObterDescricao()
    {
        throw new NotImplementedException();
    }
}
