// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };
Dictionary <string, List<int>> bandasRegistradas = new();
bandasRegistradas.Add("Pink Floyd", new List<int> {10,8,6});
bandasRegistradas.Add("Twenty One Pilots", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ListarBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            CalcularAMediaDaBanda();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloEstilizado("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    var nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ListarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloEstilizado("Lista das Bandas.");

    /*for (int i = 0; i < listaDasBandas.LongCount(); i++)
    {
        Console.WriteLine($"{i+1}º - {listaDasBandas[i]}");
    }*/


    foreach(var banda in bandasRegistradas.Keys) {
        
        Console.WriteLine($"Banda - {banda}");
    }

    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu.");
    Console.ReadKey(true);
    { 
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirTituloEstilizado(string titulo)
{
    int quantLetra = titulo.Length;
    string asteristico = string.Empty.PadLeft(quantLetra, '*');
    Console.WriteLine(asteristico);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristico);
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloEstilizado("Avaliar Banda");

    Console.Write("Qual banda você deseja avaliar:");
    string bandaParaSerAvaliada = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(bandaParaSerAvaliada))
    {
        Console.Write($"Qual nota você acha que a banda {bandaParaSerAvaliada} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[bandaParaSerAvaliada].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi cadastrada com sucesso a banda {bandaParaSerAvaliada}");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nBanda {bandaParaSerAvaliada} não encontrada!");
        Console.WriteLine("Digite qualquer tecla para retorna ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void CalcularAMediaDaBanda()
{
    Console.Clear();
    ExibirTituloEstilizado("Apresetação de Média das Bandas ");

    Console.Write("Qual banda você deseja ver a média: ");
    string bandaMedia = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(bandaMedia))
    {
        List<int> media = bandasRegistradas[bandaMedia];
        Console.WriteLine($"A média da banda {bandaMedia} é {media.Average()}");
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nBanda {bandaMedia} não encontrada!");
        Console.WriteLine("Digite qualquer tecla para retorna ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

ExibirOpcoesDoMenu();