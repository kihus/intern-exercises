using Exercises.Services;

try
{
    // Média e Aprovação
    MediaService.Media();

    // Verificação de número par ou impar
    VerficaNumeroParOuImparService.VerificaNumeroParOuImpar();

    // Maior de dois números
    MaiorDeDoisNumerosService.MaiorDeDoisNumeros();

    // Calculo de IMC
    CalculoIMCService.CalculoIMC();

    // Verificação de múltiplos
    VerificacMultiplosService.VerificaMultiplos();

    // Desconto em produto
    DescontoEmProdutoService.DescontoEmProduto();

    // Classificação de triangulo
    ClassificaTrianguloService.ClassificaTriangulo();

    // Média ponderada
    MediaPonderadaService.MediaPonderada();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}