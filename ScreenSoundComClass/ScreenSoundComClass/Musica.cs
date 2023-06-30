class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"A música {Nome} pertence á banda {Artista.Nome}";
    public Genero Genero { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Tempo: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"Plano Disponivel");
        }
        else
        {
            Console.WriteLine($"Adquira o Plano Plus+");
        }
        Console.WriteLine(DescricaoResumida);
    }

    public void ExibaNomeEArtista()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
    }



    //Desafio Lambda
    public static int Somar(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }

    public static int SomarLambda(int a, int b) => a + b;
}