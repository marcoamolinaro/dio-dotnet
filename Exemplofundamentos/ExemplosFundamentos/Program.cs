using ExemplosFundamentos.Common.Models;

// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Marco";
// pessoa1.Idade = 59;
// pessoa1.Apresentar();

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Muito bom!");

// Calculadora calculadora = new Calculadora();

// calculadora.Somar(5,5);
// calculadora.SomSubtrair(5,5);
// calculadora.Multiplicar(5,5);
// calculadora.Dividir(5,5);
// calculadora.Potencia(3,3);

// calculadora.Seno(30);
// calculadora.Coseno(30);
// calculadora.Tangente(30);

// int numero = 10;
// Console.WriteLine($"Incrementando o {numero} = {++numero}");

// Console.WriteLine($"Decrementando o {numero} = {--numero}");

//calculadora.RaizQuadrada(9);
//int numero = 5;
//int contador = 0;
// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// while (contador <= 10) 
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 8)
//     {
//         break;
//     }
// }

// do 
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// } while (contador <= 10);

// int soma = 0, numero = 0;

// do 
// {
//     Console.WriteLine("Digite um número (0 para)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// string? opcao;
// bool exibir = true;

// while (exibir)
// {
//     Console.WriteLine("Digite uma opção");
//     Console.WriteLine("1 = Cadastrar Cliente");
//     Console.WriteLine("2 = Buscar Cliente");
//     Console.WriteLine("3 = Apagar Cliente");
//     Console.WriteLine("4 = Sair");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Clientes");
//             break;

//         case "2":
//             Console.WriteLine("Buscar os Clientes");
//             break;

//         case "3":
//             Console.WriteLine("Apagar o Cliente");
//             break;

//         case "4":
//             Console.WriteLine("Sair");
//             exibir = false;    
//             break;

//         default:
//             Console.WriteLine("Opção inváida");
//             break;
//     }
// }

// Teste Usando Main (Nas versões >= .NET6 não é mais necessário)

// namespace ExemplosFundamentos
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Pessoa p1 = new Pessoa();
//             p1.Nome = "Marco";
//             p1.Idade = 59;
//             p1.Apresentar();
//         }
//     }
// }

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 1;
arrayInteiros[1] = 2;
arrayInteiros[2] = 3;
//arrayInteiros[3] = 4; Erro

Console.WriteLine("Pecorrendo um array com FOR");
for (int ind = 0; ind < arrayInteiros.Length; ind++) 
{
    Console.WriteLine($"Indice {ind} contém o valor {arrayInteiros[ind]}");
}

Console.WriteLine("Pecorrendo um array com FOREACH");
int ind1 = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Indice {ind1} contém o valor {valor}");
    ind1++;
}
