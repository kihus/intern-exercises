
using Exercises.Entities;
using System.Globalization;

namespace Exercises.Services;

static class CalculoIMCService
{
    public static void CalculoIMC()
    {
        Console.WriteLine("----- Cálculo de IMC -----");
        Console.Write("Escreva sua altura (m): ");
        var altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Escreva seu peso (kg): ");
        var peso = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Calculator.CalcularIMC(peso, altura);
        Console.WriteLine();

    }
}
