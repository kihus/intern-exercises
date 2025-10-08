using Exercises.Entities;
using System.Globalization;

namespace Exercises.Services;

internal class MediaPonderadaService
{
    public static void MediaPonderada()
    {
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
}
