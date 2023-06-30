using ScreenSoundAPI.Modelos;
using System.Linq;

namespace ScreenSoundAPI.Filtros
{
    internal class LinqOrder
    {
        public static void OrdenadorDeArtistas(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
            Console.WriteLine($"Total: {artistasOrdenados.Count}");
        }
    }
}
