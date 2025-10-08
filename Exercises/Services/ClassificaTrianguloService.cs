using Exercises.Entities;
using System.Globalization;

namespace Exercises.Services;

internal class ClassificaTrianguloService
{
    public static void ClassificaTriangulo()
    {
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
    }
}
