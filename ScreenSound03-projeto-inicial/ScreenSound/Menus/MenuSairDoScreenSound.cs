using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSairDoScreenSound : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
