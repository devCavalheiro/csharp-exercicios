namespace exercicios04_polimorfismo.Models.Reservas;

public class Reserva
{
    public string Titulo { get; }

    public Reserva(string titulo)
    {
        Titulo = titulo;
    }

    public virtual void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva genérica: {Titulo}");
    }
}
