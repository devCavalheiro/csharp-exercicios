namespace exercicios04_polimorfismo.Models.Botoes;

public class EditarAcao : IAcaoBotao
{
    public void Executar() => Console.WriteLine("Editando informações do cadastro...");
}