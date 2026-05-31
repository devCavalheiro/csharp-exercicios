using exercicios02_i_h.Models.Clientes;
using exercicios02_i_h.Models.Funcionarios;
using exercicios02_i_h.Models.Certificados;
using exercicios02_i_h.Models.Sensores;
using exercicios02_i_h.Models.Computadores;
using exercicios02_i_h.Models.Pagamentos;
using exercicios02_i_h.Models.Servicos;
using exercicios02_i_h.Models.Cursos;

Console.Clear();

// ClienteVIP cliente1 = new("Renata", 32, "Ouro", "VIP123A");
// ClienteVIP cliente2 = new("Leonardo", 40, "Diamante", "VIP789X");

// cliente1.SaudacaoVIP();
// Console.WriteLine();
// cliente2.SaudacaoVIP();



// Interno f1 = new Interno("Luciana", "Desenvolvedora", 7000.00m);
// Freelancer f2 = new Freelancer("Carlos", "Designer", 3500.00m);

// f1.ExibirInformacoes();
// Console.WriteLine();
// f2.ExibirInformacoes();



// Analista analista = new Analista("Analista de Sistemas");
// Docente docente = new Docente("Docente de Matemática");
// Certificado certf1 = new Certificado(); 
// Certificado certf2 = new Certificado();

// certf1.ExibirMensagem(analista);
// certf2.ExibirMensagem(docente);



// SensorTemperatura temp = new SensorTemperatura();
// SensorPresenca presenca = new SensorPresenca();

// temp.Ativar();
// temp.Desativar();

// presenca.Ativar();
// presenca.Desativar();



// Processador cpu = new Processador("Intel", "i7-12700K");
// PlacaMae mobo = new PlacaMae("ASUS", "LGA1700");
// Computador pc = new Computador(cpu, mobo);

// pc.ExibirConfiguracao();



// PagamentoCredito cliente1 = new PagamentoCredito("André", "andre@email.com");
// PagamentoBoleto cliente2 = new PagamentoBoleto("Juliana", "juliana@email.com");

// cliente1.ProcessarPagamento();
// cliente2.ProcessarPagamento();



// exercicios02_i_h.Models.Servicos.Funcionario tecnico = new("João", "TI");
// IServico s1 = new Manutencao("Atualização de servidor", tecnico);

// exercicios02_i_h.Models.Servicos.Funcionario analista = new("Marina", "Consultoria");
// IServico s2 = new Consultoria("Planejamento estratégico", analista);

// s1.ExecutarServico();

Console.WriteLine();

// s2.ExecutarServico();



Instrutor instrutor1 = new Instrutor("Carla", "Back-end");
ICurso curso1 = new CursoProgramacao("C# com POO", instrutor1);

Instrutor instrutor2 = new Instrutor("Felipe", "UI/UX");
ICurso curso2 = new CursoDesign("Design de Interfaces", instrutor2);

curso1.ValidarConteudo();
curso1.PublicarCurso();

Console.WriteLine();

curso2.ValidarConteudo();
curso2.PublicarCurso();