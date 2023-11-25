using ExemploExplorando.Models;
using System.Globalization;

// DateTime
DateTime data = DateTime.Now;
Console.WriteLine(data);

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
Console.WriteLine(data);

Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

DateTime dataP = DateTime.Parse("13/07/1988 07:53");
Console.WriteLine(dataP);

string dataString = "2022-04-17 18:00";
bool sucesso = DateTime.TryParseExact( dataString,
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime data2);

if (sucesso)
{
    Console.WriteLine($"Conversão com Sucesso! Data: {data2}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida!");
}

// DateTime data2 = DateTime.Parse(dataString);
Console.WriteLine(data2);

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 4582.40M;
// Console.WriteLine($"{valorMonetario:C}");

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("C8"));

// double porcentagem = 0.3422;
// Console.WriteLine(porcentagem.ToString("P"));

// Testando a Classe Cursos COM Construtores
// Pessoa p1 = new Pessoa("Pedro", "Padilha");
// Pessoa p2 = new Pessoa(nome: "Manoela", sobrenome: "Marra");

// Curso curso1 = new Curso();
// curso1.Nome = "Inglês";
// curso1.Alunos = new List<Pessoa>();
// curso1.AdicionarAluno(p1);
// curso1.AdicionarAluno(p2);
// curso1.ListarAlunos();

// Testando a Classe Cursos SEM Construtores

// Pessoa p1 = new Pessoa("Pedro", "Padilha");
// p1.Nome = "Pedro";
// p1.Sobrenome = "Padilha";
// p1.Idade = 35;

// Pessoa p2 = new Pessoa();
// p2.Nome = "Manoela";
// p2.Sobrenome = "Marra";
// p2.Idade = 32;

// Curso curso1 = new Curso();
// curso1.Nome = "Inglês";
// curso1.Alunos = new List<Pessoa>();
// curso1.AdicionarAluno(p1);
// curso1.AdicionarAluno(p2);
// curso1.ListarAlunos();

// Testando a classe Pessoa

// Pessoa p1 = new Pessoa();
// p1.Nome = "Asdrubal";
// p1.Sobrenome = "Nogueira";
// p1.Idade = 47;
// p1.Apresentar();