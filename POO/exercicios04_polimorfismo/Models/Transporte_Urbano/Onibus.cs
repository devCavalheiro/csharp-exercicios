namespace exercicios04_polimorfismo.Models.Transporte_Urbano;

public class Onibus : Transporte
{
    public override int CalcularTempo(int distanciaKm) => distanciaKm * 2 + 5;
}
