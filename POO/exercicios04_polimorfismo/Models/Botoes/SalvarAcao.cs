namespace exercicios04_polimorfismo.Models.Botoes;

public class SalvarAcao : IAcaoBotao
{
    public void Executar() => Console.WriteLine("Salvando dados no banco...");
}