using ScreenSoundAPI.Modelos;
using System.Linq;

namespace ScreenSoundAPI.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicas = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var gen in todosOsGenerosMusicas)
            {
                Console.WriteLine($"- {gen}");
            }
            Console.WriteLine($"Total: {todosOsGenerosMusicas.Count}");
        }

        public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var todosOsArtistasPorGenerosMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            todosOsArtistasPorGenerosMusical.Sort();


            foreach (var artista in todosOsArtistasPorGenerosMusical)
            {
                Console.WriteLine($"- {artista}");
            }
            Console.WriteLine($"- {todosOsArtistasPorGenerosMusical.Count}");
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
        {
            var musicaDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();

            Console.WriteLine($"{nomeDoArtista}");
            foreach (var musica in musicaDoArtista)
            {
                Console.WriteLine($"-{musica.Nome}");
            }
        }

        public static void FIltrarMusicasPorAno(List<Musica> musicas, int ano)
        {
            var musicaDoAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musica => musica.Ano).Select(musicas => musicas.Nome).Distinct().ToList();

            Console.WriteLine($"Ano:{ano}");

            foreach (var musica in musicaDoAno)
            {
                Console.WriteLine($"{musica}");
            }
        }

        public static void FiltrarMusicaPorTonalidade(List<Musica> musicas, string tonalidade)
        {
            var musicaTonalidade = musicas
                .Where(musica => musica.KeyInt == 1)
                .Select(musica => musica.Nome)
                .ToList();


            Console.WriteLine($" {tonalidade}");
            foreach (var nota in musicaTonalidade)
            {
                Console.WriteLine($"- {nota}");
            }
            Console.WriteLine($"Total:{musicas.Count}");
        }

    }
}
