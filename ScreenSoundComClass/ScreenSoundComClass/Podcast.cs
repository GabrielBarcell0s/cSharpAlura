class Podcast
{
    List<Episodio> episodios = new();

    public Podcast(string host, string nome) 
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;
    
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Apresentando o Podcast {Nome}");
        Console.WriteLine($"Disponivel na host:{Host}\n");

        foreach (var ep in episodios.OrderBy(n => n.Ordem))
        { 
            Console.WriteLine($"{ep.Resumo}");
        }
        Console.WriteLine($"\nTotal de Episódios:{TotalEpisodios}");
    }

}