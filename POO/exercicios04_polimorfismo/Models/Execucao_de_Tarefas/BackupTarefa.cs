namespace exercicios04_polimorfismo.Models.Execucao_de_Tarefas;

public class BackupTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Executando tarefa de backup do sistema...");
    }
}
