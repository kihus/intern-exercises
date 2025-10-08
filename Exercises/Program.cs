using Exercises.Entities;
using System.Globalization;

try
{

    // Média e Aprovação
    Console.WriteLine("----- Média e Aprovação -----");
    Console.WriteLine("Digite 3 notas do aluno(a): ");

    Console.Write("Primeira nota: ");
    var primeiraNota = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Segunda nota: ");
    var segundaNota = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Terceira nota: ");
    var terceiraNota = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Calculator.Media(primeiraNota, segundaNota, terceiraNota);
    Console.WriteLine();

    // Verificação de número par ou impar
    Console.WriteLine("----- Verificação de número par ou impar -----");
    Console.Write("Coloque um número inteiro: ");
    var num = int.Parse(Console.ReadLine()!);

    if (Calculator.VeficaParOuImpar(num))
        Console.WriteLine("Número par");
    else
        Console.WriteLine("Número impar");

    Console.WriteLine();

    // Maior de dois números
    Console.WriteLine("----- Maior de dois números -----");
    Console.WriteLine("Escreva dois números");

    Console.Write("Primeiro número: ");
    var num1 = int.Parse(Console.ReadLine()!);

    Console.Write("Primeiro número: ");
    var num2 = int.Parse(Console.ReadLine()!);

    Calculator.MaiorNumero(num1, num2);
    Console.WriteLine();

    // Calculo de IMC
    Console.WriteLine("----- Calculo de IMC -----");
    Console.Write("Escreva sua altura (m): ");
    var altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Escreva seu peso (kg): ");
    var peso = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Calculator.CalcularIMC(peso, altura);
    Console.WriteLine();

    // Verificação de múltiplos
    Console.WriteLine("----- Verificação de múltiplos ----- ");
    Console.WriteLine("Escreva 2 números inteiros");
    var numMult1 = int.Parse(Console.ReadLine()!);
    var numMult2 = int.Parse(Console.ReadLine()!);

    Calculator.Multiplos(numMult1, numMult2);
    Console.WriteLine();

    // Desconto em produto
    Console.WriteLine("----- Desconto em produto -----");
    Console.Write("Digite o valor do produto: ");
    var valorProd = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Digite a forma de pagamento (1 - à vista, 2 - parcelado): ");
    var formaPagamento = int.Parse(Console.ReadLine()!);

    Calculator.Desconto(valorProd, formaPagamento);
    Console.WriteLine();

    // Classificação de triangulo
    Console.WriteLine("----- Classificação de triangulo -----");
    Console.WriteLine("Escreva os 3 lados do triangulo");

    Console.Write("Primeiro lado: ");
    var primeiroLado = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Segundo lado: ");
    var segundoLado = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Terceiro lado: ");
    var terceiroLado = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Calculator.ClassificarTriangulo(primeiroLado, segundoLado, terceiroLado);
    Console.WriteLine();

    // Média ponderada
    Console.WriteLine("----- Média ponderada -----");
    Console.Write("Digite a primeira nota: ");
    var nota1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Digite o peso da nota: ");
    var peso1 = int.Parse(Console.ReadLine()!);

    Console.Write("Digite a segunda nota: ");
    var nota2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Digite o peso da nota: ");
    var peso2 = int.Parse(Console.ReadLine()!);

    Console.Write("Digite a terceira nota: ");
    var nota3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Digite o peso da nota: ");
    var peso3 = int.Parse(Console.ReadLine()!);

    Calculator.MediaPonderada(nota1, peso1,
                              nota2, peso2,
                              nota3, peso3);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}