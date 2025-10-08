
using Exercises.Entities;

namespace Exercises.Services;

static class MaiorDeDoisNumerosService
{
    public static void MaiorDeDoisNumeros()
    {
        Console.WriteLine("----- Maior de dois números -----");
        Console.WriteLine("Escreva dois números");

        Console.Write("Primeiro número: ");
        var num1 = int.Parse(Console.ReadLine()!);

        Console.Write("Primeiro número: ");
        var num2 = int.Parse(Console.ReadLine()!);

        Calculator.MaiorNumero(num1, num2);
        Console.WriteLine();
    }
}
