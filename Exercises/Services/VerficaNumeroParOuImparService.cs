using Exercises.Entities;

namespace Exercises.Services;
static class VerficaNumeroParOuImparService
{
    public static void VerificaNumeroParOuImpar()
    {
        Console.WriteLine("----- Verificação de número par ou impar -----");
        Console.Write("Coloque um número inteiro: ");
        var num = int.Parse(Console.ReadLine()!);

        if (Calculator.VeficaParOuImpar(num))
            Console.WriteLine("Número par");
        else
            Console.WriteLine("Número impar");

        Console.WriteLine();
    }
}
