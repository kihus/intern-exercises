using Exercises.Entities;
using System.Globalization;

namespace Exercises.Services;

internal class DescontoEmProdutoService
{
    public static void DescontoEmProduto()
    {
        Console.WriteLine("----- Desconto em produto -----");
        Console.Write("Digite o valor do produto: ");
        var valorProd = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Digite a forma de pagamento (1 - à vista, 2 - parcelado): ");
        var formaPagamento = int.Parse(Console.ReadLine()!);

        Calculator.Desconto(valorProd, formaPagamento);
        Console.WriteLine();
    }
}
