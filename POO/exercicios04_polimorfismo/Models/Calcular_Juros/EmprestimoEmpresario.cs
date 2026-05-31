namespace exercicios04_polimorfismo.Models.Calcular_Juros;

public class EmprestimoEmpresario : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses) => valor + (valor * 0.025m * meses);
}
