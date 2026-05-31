namespace exercicios04_polimorfismo.Models.Execucao_de_Tarefas;

public class LimpezaTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Limpando arquivos temporários do servidor...");
    }
}
