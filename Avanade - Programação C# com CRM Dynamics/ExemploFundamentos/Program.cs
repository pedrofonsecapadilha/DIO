




// Exercícios - Operadores Condicionais

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
// {
//     Console.WriteLine("É uma vogal!!");
// }
// else
// {
//     Console.WriteLine("NÃO é uma vogal :(");
// }

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal!!");
//         break;
//     default:
//         Console.WriteLine("NÃO é uma vogal :(");
//         break;
// }

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Inválida");
// }
// else if (quantidadeEmEstoque > quantidadeCompra)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada.");
// }

// Exercícios - Operadores de Atribuição
// using ExemploFundamentos.Models;

// string h = "15";
// int i = 3;
// int.TryParse(h, out i);
// Console.WriteLine(i);

// // Cast - Casting
// // int a = "5";
// int d = Convert.ToInt32("5");
// Console.WriteLine(d);
// int e = int.Parse("8");
// Console.WriteLine(e);

// // string g = 5;
// int inteiro = 5;
// string g = inteiro.ToString();
// Console.WriteLine(g);

// int a = 10;
// int b = 20;
// int c = a + b;
// // c = c + 5; 
// c += 5;
// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine("\nData e hora atual: " + dataAtual.ToString("dd/MM/yyyy HH") + "h\n");

// string apresentacao = "Olá, seja bem vindx";
// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade 1: " + quantidade);
// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade 2: " + quantidade);
// double altura = 1.80;
// decimal preco = 1.85M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço: " + preco);
// Console.WriteLine("Valor da variável condição: " + condicao + '\n');

// Pessoa p = new Pessoa();

// p.Nome = "Pedro";
// p.Idade = 35;
// p.Apresentar();