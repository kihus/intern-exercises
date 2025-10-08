using Exercises.Entities;
using System.Globalization;

namespace Exercises.Services;

static class MediaService
{
    public static void Media()
    {
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
    }
}
