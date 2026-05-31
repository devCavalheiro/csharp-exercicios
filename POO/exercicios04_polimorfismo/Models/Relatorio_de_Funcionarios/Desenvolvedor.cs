namespace exercicios04_polimorfismo.Models.Relatorio_de_Funcionarios;

public class Desenvolvedor : Funcionario
{
    public override string GerarRelatorio()
    {
        return "Relatório do desenvolvedor: escreve código e corrige bugs.";
    }
}
