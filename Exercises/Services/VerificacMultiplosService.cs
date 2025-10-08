using Exercises.Entities;

namespace Exercises.Services;

static class VerificacMultiplosService
{
    public static void VerificaMultiplos()
    {
        Console.WriteLine("----- Verificação de múltiplos ----- ");
        Console.WriteLine("Escreva 2 números inteiros");

        Console.Write("Primeiro Número: ");
        var numMult1 = int.Parse(Console.ReadLine()!);

        Console.Write("Segundo Número: ");
        var numMult2 = int.Parse(Console.ReadLine()!);

        Calculator.Multiplos(numMult1, numMult2);
        Console.WriteLine();
    }
}
