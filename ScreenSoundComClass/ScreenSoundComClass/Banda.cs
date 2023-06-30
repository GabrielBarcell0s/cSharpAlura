class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    private List<Album> albums = new List<Album>();
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        foreach (Album album in albums)
        {
            Console.WriteLine($"Exibindo Discografia do Banda {Nome}");
            Console.WriteLine($"O Album {album.Nome} tem {album.DuracaoTotal} segundos de duração.");

        }
    }
}