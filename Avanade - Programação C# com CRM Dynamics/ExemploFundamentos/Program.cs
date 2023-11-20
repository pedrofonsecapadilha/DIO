using ExemploFundamentos.Models;

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine("Data e hora atual: " + dataAtual.ToString("dd/MM/yyyy HH") + "h\n");

string apresentacao = "Olá, seja bem vindx";
int quantidade = 1;
quantidade = 10;
double altura = 1.80;
decimal preco = 1.85M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preço: " + preco);
Console.WriteLine("Valor da variável condição: " + condicao);

Pessoa p = new Pessoa();

p.Nome = "Pedro";
p.Idade = 35;
p.Apresentar();