using sistema_de_rotina.Interfaces;

namespace sistema_rotina_inteligente.Models;

public class ExecutarTodasRotinas
{
    public async Task ExecutarTodas(List<IRotina> rotinas)
    {
        try
        {
            foreach (var rotina in rotinas)
            {
                rotina.Executar();
                await Task.Delay(100);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}