using Exercises.Services;

try
{
    string escolhaPadrao;
    do
    {
        // Texto de apresentação das opções
        Console.WriteLine("## Escolha sua Opção de Programa\n");
        Console.WriteLine("Olá! Para continuar, por favor, escolha o programa que você deseja executar digitando o número correspondente à opção desejada (de 1 a 8).\n");

        // Tabela de opções
        Console.WriteLine("| Número | Programa |");
        Console.WriteLine("| :---: | :--- |");
        Console.WriteLine("| **1** | Média e Aprovação |");
        Console.WriteLine("| **2** | Verificação de número par ou ímpar |");
        Console.WriteLine("| **3** | Maior de dois números |");
        Console.WriteLine("| **4** | Cálculo de IMC |");
        Console.WriteLine("| **5** | Verificação de múltiplos |");
        Console.WriteLine("| **6** | Desconto em produto |");
        Console.WriteLine("| **7** | Classificação de triângulo |");
        Console.WriteLine("| **8** | Média ponderada |");
        Console.WriteLine("-------------------------------------------\n");

        // Solicita a entrada do usuário
        Console.Write("Digite o número da sua escolha (de 1 a 8): ");
        var escolha = int.Parse(Console.ReadLine()!);

        // Exemplo simples de como você pode usar a escolha em um switch (opcional, mas útil)
        Console.WriteLine($"\nVocê escolheu a opção: {escolha}");

        switch (escolha)
        {
            case 1:
                // Média e Aprovação
                MediaService.Media();
                break;

            case 2:
                // Verificação de número par ou impar
                VerficaNumeroParOuImparService.VerificaNumeroParOuImpar();
                break;

            case 3:

                // Maior de dois números
                MaiorDeDoisNumerosService.MaiorDeDoisNumeros();
                break;

            case 4:
                // Calculo de IMC
                CalculoIMCService.CalculoIMC();
                break;

            case 5:
                // Verificação de múltiplos
                VerificacMultiplosService.VerificaMultiplos();
                break;

            case 6:
                // Desconto em produto
                DescontoEmProdutoService.DescontoEmProduto();
                break;

            case 7:
                // Classificação de triangulo
                ClassificaTrianguloService.ClassificaTriangulo();
                break;

            case 8:
                // Média ponderada
                MediaPonderadaService.MediaPonderada();
                break;


            default:
                Console.WriteLine("Deseja escolher outro exercício?");
                break;

        }
        Console.WriteLine("Deseja escolher outro exercício?");
        escolhaPadrao = Console.ReadLine()!;
       

    } while (escolhaPadrao.ToLower() == "s" || escolhaPadrao.ToLower() == "sim");

}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}