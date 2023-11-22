// Exercícios - Array e Listas

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 100;
// arrayInteiros[1] = 225;
// arrayInteiros[2] = 375;

// int[] arrayInteiros = { 100, 225, 354 };

// // for(int count = 0; count < arrayInteiros.Length; count++)
// // {
// //     Console.WriteLine($"Posição: {count} - Valor: {arrayInteiros[count]}");
// // }

// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }

List<string> exemplo = new List<string>();
exemplo.Add("SP");
exemplo.Add("MG");
exemplo.Add("BA");

foreach(string item in exemplo)
{
    Console.WriteLine(item);
}

// Exercícios - Conhecendo as Estruturas de Repetição em C#

// int numero = 7;

// for(int count = 0; count <= 10; count++)
// {
//     Console.WriteLine($"{numero} x {count} = {numero * count}");
// }

// int numero = 8;
// int count = 0;

// while (count <= 10)
// {
//     Console.WriteLine($"{numero} x {count} = {numero * count}");
//     count++;
// }

// int sum = 0, num = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     num = Convert.ToInt32(Console.ReadLine());

//     sum += num;

// } while(num != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {sum}");

// string opcao;

// while(true)
// {
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Buscar cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção Inválida");
//             break;
//     }
// }

// Exercícios - Operadores Aritiméticos em C#

// using ExemploFundamentos.Models;

// Calculadora calc = new Calculadora();

// calc.Somar(6,3);
// calc.Subtrair(6,3);
// calc.Multiplicar(6,3);
// calc.Dividir(6,3);
// calc.Potencia(6,3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(36);

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