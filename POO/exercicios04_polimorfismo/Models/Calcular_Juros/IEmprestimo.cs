namespace exercicios04_polimorfismo.Models.Calcular_Juros;

public interface IEmprestimo
{
    decimal CalcularValorFinal(decimal valor, int meses);
}
