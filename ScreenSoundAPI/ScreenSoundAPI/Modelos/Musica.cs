

using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelos
{
    internal class Musica
    {
        [JsonPropertyName("song")]
        public string? Nome { get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        [JsonPropertyName("year")]
        public string? AnoString { get; set; }
        public int Ano => int.Parse(AnoString!);
        [JsonPropertyName("key")]
        public int KeyInt { get; set; }

        public string Tonalidade => TransformarKeyEmTonalidade();
        


        public void ExibirDetelhasDaMusica()
        {
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Artísta: {Artista}");
            Console.WriteLine($"Duração(ms): {Duracao / 1000}");
            Console.WriteLine($"Genêro: {Genero}");
            Console.WriteLine($"Nota: {Tonalidade}");
        }

        public string TransformarKeyEmTonalidade()
        {
            string nota = string.Empty;
            switch (KeyInt)
            {
                case 0: nota = "C"; break;
                case 1: nota = "C#"; break;
                case 2: nota = "D"; break;
                case 3: nota = "D#"; break;
                case 4: nota = "E"; break;
                case 5: nota = "F"; break;
                case 6: nota = "F#"; break;
                case 7: nota = "G"; break;
                case 8: nota = "G#"; break;
                case 9: nota = "A"; break;
                case 10: nota = "A#"; break;
                case 11: nota = "B"; break;
            }
            return nota;

        }
    }
}
