namespace exercicios04_polimorfismo.Models.Transporte_Urbano;

public class Bicicleta : Transporte
{
    public override int CalcularTempo(int distanciaKm) => distanciaKm * 4;
}
