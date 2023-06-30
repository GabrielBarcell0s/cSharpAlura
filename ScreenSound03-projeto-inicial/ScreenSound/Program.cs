using ScreenSound.Menus;
using ScreenSound.Modelos;

Banda u2 = new("U2");

u2.AdicionarNota(new Avaliacao(10));
u2.AdicionarNota(new Avaliacao(8));
u2.AdicionarNota(new Avaliacao(6));

Banda imagineDragons = new("Imagine Dragons");

Dictionary<string, Banda> bandasRegistradas = new()
        {
            { u2.Nome, u2 },
            { imagineDragons.Nome, imagineDragons }
        };

Dictionary<int, Menu> opcoes = new()
{
    {1, new MenuRegistrarBanda()},
    {2, new MenuRegistrarAlbum()},
    {3, new MenuExibirBandasRegistradas()},
    {4, new MenuAvaliarBanda()},
    {5, new MenuAvaliarAlbum() },
    {6, new MenuExibirDetalhes()},
    {-1, new MenuSairDoScreenSound()}
};


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
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}




void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar uma álbum");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuExibirNoConsole = opcoes[opcaoEscolhidaNumerica];
        menuExibirNoConsole.Executar(bandasRegistradas);
        if(opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }

}
ExibirOpcoesDoMenu();
