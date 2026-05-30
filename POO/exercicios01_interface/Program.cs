using exercicios_poo_cs_interface_1.Models.Formas;
using exercicios_poo_cs_interface_1.Models.Pagamento;
using exercicios_poo_cs_interface_1.Models.Veiculos;
using exercicios_poo_cs_interface_1.Models.Notificacao;
using exercicios_poo_cs_interface_1.Models.Armazenamento;

Console.Clear();


Retangulo retangulo = new(5, 3);
Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea():F2}");
Console.WriteLine($"Perímetro do retângulo: {retangulo.CalcularPerimetro():F2}");

Circulo circulo = new(4);
Console.WriteLine($@"Área do círculo: {circulo.CalcularArea():F2}");
Console.WriteLine($"Perímetro do círculo: {circulo.CalcularPerimetro():F2}");


Console.WriteLine();
Console.WriteLine();


Veiculo veiculo = new();
veiculo.Pilotar();
veiculo.Voar();


Console.WriteLine();
Console.WriteLine();


Produto produto = new("Notebook", 3500m, 2);
Console.WriteLine($"Valor de '{produto.Quantidade}' '{produto.Nome}(s)': R${produto.CalcularPagamento():F2}");

Servico servico = new("Manutenção", 100m, 5);
Console.WriteLine($"Valor de '{servico.Nome}': R${servico.CalcularPagamento():F2}");


Console.WriteLine();
Console.WriteLine();


Email email = new("usuario@exemplo.com");
email.EnviarNotificacao();

SMS sMS = new("123456789");
sMS.EnviarNotificacao();


Console.WriteLine();
Console.WriteLine();


Arquivo arquivo = new("meu_arquivo.txt");
arquivo.Salvar();
arquivo.Recuperar();

BancoDeDados bancoDeDados = new("MeuBanco");
bancoDeDados.Salvar();
bancoDeDados.Recuperar();


Console.WriteLine();