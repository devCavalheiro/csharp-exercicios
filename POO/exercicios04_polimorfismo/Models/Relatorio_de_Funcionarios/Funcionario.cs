namespace exercicios04_polimorfismo.Models.Relatorio_de_Funcionarios;

public class Funcionario
{
    public virtual string GerarRelatorio()
    {
        return "Relatório genérico do funcionário.";
    }
}
