namespace exercicios04_polimorfismo.Models.Execucao_de_Tarefas;

public class RelatorioTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Gerando e enviando relatório diário...");
    }
}
