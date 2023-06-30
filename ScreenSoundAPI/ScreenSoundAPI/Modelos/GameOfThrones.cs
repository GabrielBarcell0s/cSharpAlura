
using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelos
{
    internal class GameOfThrones
    {
        [JsonPropertyName("name")]
        public string? Nome { get; set; }
        [JsonPropertyName("born")]
        public string? DataDeNascimento { get; set; }
        [JsonPropertyName("titles")]
        public List<string> Titulos { get; set; }
        [JsonPropertyName("gender")]
        public string? Genero { get; set; }

        public void ExibirInformacoesDoPersonagem()
        {
            Console.WriteLine($"Personagem: {Nome}");
            Console.WriteLine($"Genêro: {Genero}");
            Console.WriteLine($"Títulos: {Titulos[0]}");
            Console.WriteLine($"Data de nascimento: {DataDeNascimento}");

        }

    }
}
