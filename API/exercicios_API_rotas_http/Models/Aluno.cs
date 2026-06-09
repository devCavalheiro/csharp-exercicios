namespace exercicios_API_rotas.Models;

public class Aluno
{
    private static int proximoId = 1;

    public int Id { get; private set; }
    public string Nome { get; set; }
    public double NotaUm { get; set; }
    public double NotaDois { get; set; }
    public double Media { get => (NotaUm + NotaDois) / 2; }

    public Aluno(string nome, double notaUm, double notaDois)
    {
        Id = proximoId++;
        Nome = nome;
        NotaUm = notaUm;
        NotaDois = notaDois;
    }
}