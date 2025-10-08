using Exercises.Entities;

// Média e Aprovação
Console.WriteLine("----- Média e Aprovação -----");
Console.WriteLine("Digite 3 notas do aluno(a): ");
var primeiraNota = double.Parse(Console.ReadLine() ?? "0");
var segundaNota = double.Parse(Console.ReadLine() ?? "0");
var terceiraNota = double.Parse(Console.ReadLine() ?? "0");

Calculator.Media(primeiraNota, segundaNota, terceiraNota);

// Verificação de número par ou inteiro
Console.WriteLine("----- Verificação de número par ou inteiro -----");
Console.Write("Coloque um número inteiro: ");
var num = int.Parse(Console.ReadLine() ?? "0");

Calculator.VeficaParOuImpar(num);

// Maior de dois números
Console.WriteLine("----- Maior de dois números -----");
Console.WriteLine("Escreva dois números");
var num1 = int.Parse(Console.ReadLine() ?? "0");
var num2 = int.Parse(Console.ReadLine() ?? "0");

Calculator.MaiorNumero(num1, num2);

// Calculo de IMC
Console.WriteLine("----- Calculo de IMC -----");
Console.Write("Escreva sua altura: ");
var altura = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Escreva seu peso: ");
var peso = double.Parse(Console.ReadLine() ?? "0");

Calculator.CalcularIMC(altura, peso);

// Verificação de múltiplos
Console.WriteLine("----- Verificação de múltiplos ----- ");
Console.WriteLine("Escreva 2 números inteiros");
var numMult1 = int.Parse(Console.ReadLine() ?? "0");
var numMult2 = int.Parse(Console.ReadLine() ?? "0");

Calculator.Multiplos(numMult1, numMult2);

// Desconto em produto
Console.WriteLine("----- Desconto em produto -----");
Console.Write("Digite o valor do produto: ");
var valorProd = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite a forma de pagamento (1 - à vista, 2 - parcelado): ");
var formaPagamento = int.Parse(Console.ReadLine() ?? "0");

Calculator.Desconto(valorProd, formaPagamento);

// Classificação de triangulo
Console.WriteLine("----- Classificação de triangulo -----");
Console.WriteLine("Escreva os 3 lados do triangulo");

Console.Write("Primeiro lado: ");
var primeiroLado = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Segundo lado: ");
var segundoLado = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Terceiro lado: ");
var terceiroLado = double.Parse(Console.ReadLine() ?? "0");

Calculator.ClassificarTriangulo(primeiroLado, segundoLado, terceiroLado);

// Média ponderada
Console.WriteLine("----- Média ponderada -----");
Console.Write("Digite a primeira nota: ");
var nota1 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o peso da nota: ");
var peso1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite a segunda nota: ");
var nota2 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o peso da nota: ");
var peso2 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite a terceira nota: ");
var nota3 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o peso da nota: ");
var peso3 = int.Parse(Console.ReadLine() ?? "0");

Calculator.MediaPonderada(nota1, peso1, 
                          nota2, peso2, 
                          nota3, peso3);