namespace exercicios04_polimorfismo.Models.Calcular_Juros;

public class EmprestimoEstudante : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses) => valor + (valor * 0.01m * meses);
}
