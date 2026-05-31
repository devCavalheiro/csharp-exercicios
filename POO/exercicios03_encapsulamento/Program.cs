using exercicios03_encapsulamento.Models.Veiculo;
using exercicios03_encapsulamento.Models.Avaliacao;
using exercicios03_encapsulamento.Models.Paciente;
using exercicios03_encapsulamento.Models.Salario;
using exercicios03_encapsulamento.Models.Projeto;
using exercicios03_encapsulamento.Models.Saque;
using exercicios03_encapsulamento.Models.Agenda;
using exercicios03_encapsulamento.Models.Estudante;
using exercicios03_encapsulamento.Models.Matricula;
using exercicios03_encapsulamento.Models.Reserva;

Console.Clear();

// Veiculo veiculo = new("ABC-1234");
// veiculo.AtualizarVelocidade(72.5);

// Console.WriteLine($"Veículo: {veiculo.Placa}");
// Console.WriteLine($"Velocidade atual: {veiculo.VelocidadeAtual}  km/h");



// Avaliacao avaliacao = new("Carla Silva");
// avaliacao.AtribuirNota(11);
// avaliacao.AtribuirNota(8.5);

// Console.WriteLine("Aluno: " + avaliacao.Aluno);
// Console.WriteLine("Nota atribuída: " + avaliacao.Nota);



// Paciente paciente = new("Luiz Costa", 42);
// HistoricoMedico historico = new("XPT-9987", paciente);
// historico.ExibirCodigo();



// Funcionario f = new("Fernanda Lima", 4000);
// f.ReajustarSalario(3500); // Inválido
// f.ReajustarSalario(4200); // Válido

// Console.WriteLine($"Funcionário: {f.Nome}");
// Console.WriteLine($"Salário atual: {f.Salario:F2}");



// Projeto projeto = new Projeto("Sistema de Inventário");

// projeto.AdicionarTarefa("Implementar banco de dados");
// projeto.AdicionarTarefa("Criar tela de login");
// projeto.AdicionarTarefa("Implementar banco de dados");
// projeto.AdicionarTarefa(null);
// projeto.AdicionarTarefa(" ");

// projeto.ExibirTarefas();



// ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
// conta.Sacar(1500); // inválido
// conta.Sacar(800);  // válido

// Console.WriteLine($"Saldo atual: R$ {conta.Saldo:F2}");



// Agenda agenda = new Agenda("Marina Souza");
// agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
// agenda.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
// agenda.AdicionarContato(new Contato("Julia", "21988776655"));
// agenda.ListarContatos();



// Estudante estudante = new Estudante("Lucas Rocha");
// estudante.Nota1 = 7.5;
// estudante.Nota2 = 5.0;

// Console.WriteLine($"Estudante: {estudante.Nome}");
// Console.WriteLine($"Média: {estudante.Media}");
// Console.WriteLine($"Situação: {estudante.Situacao}");



// Curso curso = new Curso("Lógica de Programação", 2);
// curso.Matricular(new exercicios03_encapsulamento.Models.Matricula.Estudante("Rafaela"));
// curso.Matricular(new exercicios03_encapsulamento.Models.Matricula.Estudante("João"));
// curso.Matricular(new exercicios03_encapsulamento.Models.Matricula.Estudante("Mirela")); // excede o limite
// Console.WriteLine("");
// curso.ListarMatriculados();



Hospede hospede = new Hospede("Juliana Moura");
Quarto quarto = new Quarto(101);
quarto.ValorDiaria = 250;

Reserva reserva = new Reserva(hospede, quarto, 3);

reserva.MostrarReserva();