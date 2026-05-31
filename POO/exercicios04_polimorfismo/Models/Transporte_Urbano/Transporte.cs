namespace exercicios04_polimorfismo.Models.Transporte_Urbano;

public class Transporte
{
    public virtual int CalcularTempo(int distanciaKm) => distanciaKm * 5;
}
