using exercicios04_polimorfismo.Models.Avaliacao_de_Conteudos;
using exercicios04_polimorfismo.Models.Botoes;
using exercicios04_polimorfismo.Models.Calculadora;
using exercicios04_polimorfismo.Models.Calcular_Juros;
using exercicios04_polimorfismo.Models.Execucao_de_Tarefas;
using exercicios04_polimorfismo.Models.Galeria_Online;
using exercicios04_polimorfismo.Models.Notificacoes_do_Sistema;
using exercicios04_polimorfismo.Models.Relatorio_de_Funcionarios;
using exercicios04_polimorfismo.Models.Reservas;
using exercicios04_polimorfismo.Models.Transporte_Urbano;

Console.Clear();

// Calculadora calc = new();
// Console.WriteLine(calc.Somar(10, 20));
// Console.WriteLine(calc.Somar(5, 10, 15));
// Console.WriteLine(calc.Somar(3.5, 2.8));



// Funcionario f1 = new Gerente();
// Funcionario f2 = new Desenvolvedor();

// Console.WriteLine(f1.GerarRelatorio());
// Console.WriteLine(f2.GerarRelatorio());



// List<INotificacao> notificacoes = new List<INotificacao>
// {
//     new EmailNotificacao(),
//     new SmsNotificacao(),
//     new PushNotificacao()
// };

// foreach (var notificacao in notificacoes)
// {
//   notificacao.EnviarMensagem("Sistema fora do ar!");
// }



// List<TarefaAgendada> tarefas = new List<TarefaAgendada>
// {
//     new BackupTarefa(),
//     new RelatorioTarefa(),
//     new LimpezaTarefa()
// };

// foreach (var tarefa in tarefas)
// {
//   tarefa.Executar();
// }



// List<Midia> midias = new List<Midia>
// {
//     new Imagem("paisagem.jpg", "1920x1080"),
//     new Video("filme.mp4", 120)
// };

// foreach (var midia in midias)
// {
//   midia.ExibirDetalhes();
// }



// List<Reserva> reservas = new()
// {
//     new ReservaPresencial("Trilha na Serra"),
//     new ReservaOnline("Workshop de Culinária Italiana")
// };

// foreach (var reserva in reservas)
// {
//   reserva.Confirmar();
// }



// List<Conteudo> conteudos = new()
// {
//     new AulaGravada("POO na prática", 45),
//     new MaterialComplementar("Resumo do módulo 2", 12)
// };

// foreach (var conteudo in conteudos)
// {
//   conteudo.ExibirInfo();
//   Console.WriteLine();
// }



// List<Transporte> opcoes = new()
// {
//     new Onibus(),
//     new Metro(),
//     new Bicicleta()
// };

// int distanciaKm = 10;

// foreach (var transporte in opcoes)
// {
//   Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distanciaKm)} min");
// }



// List<IEmprestimo> perfis = new()
// {
//   new EmprestimoEstudante(),
//   new EmprestimoEmpresario(),
//   new EmprestimoAposentado()
// };

// foreach (var perfil in perfis)
// {
//   decimal total = perfil.CalcularValorFinal(1000m, 12);
//   Console.WriteLine($"{perfil.GetType().Name}: R${total:F2}");
// }



// List<IAcaoBotao> acoes = new List<IAcaoBotao>
// {
//     new SalvarAcao(),
//     new EditarAcao(),
//     new ExcluirAcao()
// };

// foreach (var acao in acoes)
// {
//     acao.Executar();
// }