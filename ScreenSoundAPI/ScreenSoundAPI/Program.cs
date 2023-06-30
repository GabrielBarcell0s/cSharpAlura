using ScreenSoundAPI.Modelos;
using ScreenSoundAPI.Filtros;
using System.Text.Json;

using (HttpClient client = new ())
{
    try
    {
        //Teste Request em PokeAPI
        //string respPoke = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?limit=151");

        //Desafio Request em GameOfThronesAPI
        //var resp = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");
        //ar personagensGameOfThrones = JsonSerializer.Deserialize<GameOfThrones>(resp)!
        //personagensGameOfThrones.ExibirInformacoesDoPersonagem();

        var resp = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resp);

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.OrdenadorDeArtistas(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "metal");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas ,"U2");
        //LinqFilter.FIltrarMusicasPorAno(musicas, 2012);
        LinqFilter.FiltrarMusicaPorTonalidade(musicas, "C#");



        MusicasFavoritas musicasFavoritasGabriel = new("Gabriel");

        musicasFavoritasGabriel.AdicionarMusicasFavoritas(musicas[8]);
        musicasFavoritasGabriel.AdicionarMusicasFavoritas(musicas[45]);
        musicasFavoritasGabriel.AdicionarMusicasFavoritas(musicas[865]);
        musicasFavoritasGabriel.AdicionarMusicasFavoritas(musicas[1992]);
        musicasFavoritasGabriel.AdicionarMusicasFavoritas(musicas[35]);

        //musicasFavoritasGabriel.ExibirMusicasFavoritas();


        //musicasFavoritasGabriel.GerarArquivoJson();








    }
    catch (Exception ex)
    {
        Console.WriteLine($"Tivemos um problema na requisição ({ex.Message})");
    }
    
}
