namespace Exercises.Services;

internal class VerificaNumeroService
{
   public static void VerificaDouble(double num)
    {
        if(!double.TryParse(Console.ReadLine(), out num))
        {
            throw new ArgumentException("Coloque um número");
        }
    }

    public static void VerificaInt(int num)
    {
        if (!int.TryParse(Console.ReadLine(), out num))
        {
            throw new ArgumentException("Coloque um número");
        }
    }
}
