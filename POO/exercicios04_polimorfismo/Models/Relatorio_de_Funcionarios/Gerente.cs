namespace exercicios04_polimorfismo.Models.Relatorio_de_Funcionarios;

public class Gerente : Funcionario
{
    public override string GerarRelatorio()
    {
        return "Relatório do gerente: supervisiona a equipe.";
    }
}
