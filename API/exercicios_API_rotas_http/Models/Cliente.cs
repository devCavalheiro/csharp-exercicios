namespace exercicios_API_rotas.Models;

public class Cliente
{
    private static int proximoId = 1;

    public int Id { get; private set; }
    public string Nome { get; set; }

    public Cliente(string nome)
    {
        Id = proximoId++;
        Nome = nome;
    }
}