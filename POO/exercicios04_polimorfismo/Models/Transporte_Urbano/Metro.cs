namespace exercicios04_polimorfismo.Models.Transporte_Urbano;

public class Metro : Transporte
{
    public override int CalcularTempo(int distanciaKm) => distanciaKm + 5;
}
