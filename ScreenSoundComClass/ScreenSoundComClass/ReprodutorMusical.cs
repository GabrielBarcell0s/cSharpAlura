class ReprodutorMusical
{
    private int song;
    private int songEnd;
    


    public void ReproduzirMusica(int duracao)
    {
        song = 0;
        songEnd = duracao;

        int minutos = 0;
        int segundos = 0;
        
        string timeLine = string.Empty;

        Console.WriteLine("Reprodutor de Música(Aperte qualquer tecla para iniciar)");
        Console.WriteLine("Para Pausa a música aperte ESPAÇO");

        Console.ReadKey();

        for (; song < songEnd; song++)
        {

            if (song % 10 == 0)
            {
                timeLine += "_";
            }
            if (segundos > 59)
            {
                segundos = 0;
                minutos++;
            }
            Console.WriteLine(timeLine);
            Console.WriteLine($"\n0{minutos}:{(segundos > 9 ? segundos : $"0{segundos}")}");
            segundos++;
            Thread.Sleep(100);
            Console.Clear();


            if (Console.KeyAvailable)
            {
                // Lê a tecla pressionada
                ConsoleKeyInfo key = Console.ReadKey(true);

                // Verifica se a tecla pressionada foi a tecla de espaço
                if (key.Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine("Loop interrompido pela tecla ESPAÇO.");
                    break; // Interrompe o loop
                }
            }
        }
    }

}