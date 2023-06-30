
class Teste
{
    public void pause()
    {
        Console.WriteLine("Pressione a tecla ESPAÇO para pausar ou continuar o loop.");

        bool isPaused = false;

        for (int iteration = 0; ; iteration++)
        {
            // Verifica se uma tecla foi pressionada
            if (Console.KeyAvailable)
            {
                // Lê a tecla pressionada
                ConsoleKeyInfo key = Console.ReadKey(true);

                // Verifica se a tecla pressionada foi a tecla de espaço
                if (key.Key == ConsoleKey.Spacebar)
                {
                    isPaused = !isPaused; // Alterna entre pausado e não pausado
                    Console.WriteLine("Loop " + (isPaused ? "pausado" : "retomado") + ".");
                }
            }

            // Executa o loop normalmente se não estiver pausado
            if (!isPaused)
            {
                Console.WriteLine("Iteração: " + iteration);
            }
        }
    }
}

    