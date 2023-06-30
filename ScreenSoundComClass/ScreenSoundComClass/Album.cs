class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Exibir músicas do álbum {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
            Console.WriteLine($"Duração: {musica.Duracao} segundos");
            Console.WriteLine($"Gênero: {musica.Genero.Nome}\n");
        }
        Console.WriteLine($"Para ouvir esse álbum inteiro você precisa de {DuracaoTotal} segundos");
    }
}