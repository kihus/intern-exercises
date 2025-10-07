using Exercises.Entities;

// Média e Aprovação
Console.WriteLine("Digite 3 notas do aluno(a): ");
var primeiraNota = double.Parse(Console.ReadLine() ?? "0");
var segundaNota = double.Parse(Console.ReadLine() ?? "0");
var terceiraNota = double.Parse(Console.ReadLine() ?? "0");

Calculator.Media(primeiraNota, segundaNota, terceiraNota);

// Verificação de número par ou inteiro
Console.Write("Coloque um número inteiro: ");
var num = int.Parse(Console.ReadLine() ?? "0");

Calculator.VeficaParOuImpar(num);

// Maior de dois números
Console.WriteLine("Escreva dois números");
var num1 = int.Parse(Console.ReadLine() ?? "0");
var num2 = int.Parse(Console.ReadLine() ?? "0");

Calculator.MaiorNumero(num1, num2);

// Calculo de IMC
Console.Write("Escreva sua altura: ");
var altura = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Escreva seu peso: ");
var peso = double.Parse(Console.ReadLine() ?? "0");

Calculator.CalcularIMC(altura, peso);

// Verificação de múltiplos
Console.WriteLine("Escreva 2 números inteiros");
var numMult1 = int.Parse(Console.ReadLine() ?? "0");
var numMult2 = int.Parse(Console.ReadLine() ?? "0");

Calculator.Multiplos(numMult1, numMult2);

// Desconto em produto
Console.Write("Digite o valor do produto: ");
var valorProd = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite a forma de pagamento (1 - à vista, 2 - parcelado): ");
var formaPagamento = int.Parse(Console.ReadLine() ?? "0");

Calculator.Desconto(valorProd, formaPagamento);

// Classificação de triangulo
Console.WriteLine("Escreva os 3 lados do triangulo");

Console.Write("Primeiro lado: ");
var primeiroLado = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Segundo lado: ");
var segundoLado = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Terceiro lado: ");
var terceiroLado = double.Parse(Console.ReadLine() ?? "0");

Calculator.ClassificarTriangulo(primeiroLado, segundoLado, terceiroLado);

// Média ponderada
var nota1 = 6;
var peso1 = 20;

var nota2 = 5;
var peso2 = 30;

var nota3 = 5;
var peso3 = 50;

Calculator.MediaPonderada(nota1, peso1, nota2, peso2, nota3, peso3);