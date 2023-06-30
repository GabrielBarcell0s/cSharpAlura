class Episodio
{
    private List<string> convidados = new();
    public Episodio(string titulo, int ordem, int duracao) 
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }
    public string Titulo { get; }
    public int Ordem { get; }
    public int Duracao { get; }
    public string Resumo => $"{Ordem}º {Titulo} ({Duracao} Minutos) -" +
        $" Convidados:{string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}