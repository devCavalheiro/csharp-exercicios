namespace exercicios04_polimorfismo.Models.Calcular_Juros;

public class EmprestimoAposentado : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses) => valor + (valor * 0.015m * meses);
}
