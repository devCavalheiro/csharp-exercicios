using sistema_de_rotina.Interfaces;
using sistema_de_rotina.Models;

List<IRotina> rotinas = new()
{
    new LimpezaTemp("", DateTime.Now),
    new BackupRotina("", DateTime.Now),
    new MonitorMemoria("", DateTime.Now),
    new OrganizadorArquivos("", DateTime.Now),
    new DiagnosticoSistema("", DateTime.Now)
};