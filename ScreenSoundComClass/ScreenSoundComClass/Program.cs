Album ReflectionsinTransitAlbum = new Album();
Banda TwentyOnePilotsBanda = new Banda("Twenty One Pilots");
Musica musica1 = new Musica(TwentyOnePilotsBanda, "Stressed Out");
Musica musica2 = new Musica(TwentyOnePilotsBanda, "Heathens");
Musica musica3 = new Musica(TwentyOnePilotsBanda, "Ride");
Musica musica4 = new Musica(TwentyOnePilotsBanda, "Car Radio");
Musica musica5 = new Musica(TwentyOnePilotsBanda, "Tear In My Heart");

ReflectionsinTransitAlbum.Nome = "Reflections in Transit";
TwentyOnePilotsBanda.AdicionarAlbum(ReflectionsinTransitAlbum);

List<Musica> listaMusicas = new()
{
    musica1,
    musica2,
    musica3,
    musica4,
    musica5
};
List<int> listaDuracao = new()
{
    202,
    195,
    195,
    267,
    188
};
List<string> listaGenero = new()
{
    "Pop rock",
    "Alternative rock",
    "Alternative pop",
    "Alternative hip-hop",
    "indie pop"
};
for(int i = 0; i < listaMusicas.Count; i++)
{
    listaMusicas[i].Genero = new Genero { Nome = listaGenero[i] };
    listaMusicas[i].Duracao = listaDuracao[i]; 
    ReflectionsinTransitAlbum.AdicionarMusica(listaMusicas[i]);
}

//ReprodutorMusical reprodutor = new();
//reprodutor.ReproduzirMusica(musica1.Duracao);


//musica1.ExibirFichaTecnica();
//Console.WriteLine("\n");
//TwentyOnePilotsBanda.ExibirDiscografia();
//Console.WriteLine("\n");
//ReflectionsinTransitAlbum.ExibirMusicas();
//Teste teste = new Teste();
//teste.pause();


Podcast DevTrainer = new("Gabriel", "DevTrainer");

Episodio JuninhoLima = new("Conhecendo mais sobre C#", 2, 55);
JuninhoLima.AdicionarConvidados("Juninho Lima");
JuninhoLima.AdicionarConvidados("Tião Boscaro");

Episodio KristinaSilva = new("Conhecendo sobre o Front-end em React", 1, 84);
KristinaSilva.AdicionarConvidados("Kristina Silva");
KristinaSilva.AdicionarConvidados("Jorjão Filho");

DevTrainer.AdicionarEpisodio(JuninhoLima);
DevTrainer.AdicionarEpisodio(KristinaSilva);

DevTrainer.ExibirDetalhes();