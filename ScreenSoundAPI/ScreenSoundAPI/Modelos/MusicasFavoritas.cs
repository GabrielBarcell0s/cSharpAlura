using System.Text.Json;

namespace ScreenSoundAPI.Modelos
{
    internal class MusicasFavoritas
    {
        public MusicasFavoritas(string nome) { Nome = nome; ListaDeMusicasFavoritas = new List<Musica>(); }
        public string Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }
        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favorítas -> {Nome}");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"Música - {musica.Nome} do artísta {musica.Artista}");
            }
            Console.WriteLine();
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaDeMusicasFavoritas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"O arquivo Json foi criado com sucesso!{Path.GetFullPath(nomeDoArquivo)}");
        }

    }
}
