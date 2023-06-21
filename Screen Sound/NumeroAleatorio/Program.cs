var randomNumber = new Random();

var valueRandom = randomNumber.Next(1, 101);
int valueInput;
bool continueInput;

Console.WriteLine("Foi Gerador um número aleatório, você consegue descobri-lo?");

do
{
    do
    {
        Console.Write("\nDigite um número: ");
        var valueSTR = Console.ReadLine();

        while (string.IsNullOrEmpty(valueSTR))
        {
            Console.WriteLine("\nOps! Valor inválido.");
            Console.Write("\nDigite um número: ");
            valueSTR = Console.ReadLine();
        }

        valueInput = int.Parse(valueSTR);

        if (valueInput < valueRandom)
        {
            Console.WriteLine("\nErrado, o número é um pouco maior!");
        }
        else if (valueInput > valueRandom)
        {
            Console.WriteLine("\nErrado, o número é um pouco menor!");
        }
    } while (valueRandom != valueInput);


    Console.WriteLine($"Parabéns, você conseguiu, o número era {valueRandom}");

    Console.Write("Deseja jogar denovo?(1 - Sim/ 2 - Não):  ");

    string valueSTRContinue = Console.ReadLine();

    if (string.IsNullOrEmpty(valueSTRContinue))
    {
        while (string.IsNullOrEmpty(valueSTRContinue))
        {
            Console.WriteLine("Ops! Valor inválido.");
            Console.Write("Digite um número(1 - Sim/ 2 - Não): ");
            valueSTRContinue = Console.ReadLine();
        }

    }
    else if (int.Parse(valueSTRContinue) > 2 || int.Parse(valueSTRContinue) < 1)
    {
        while (int.Parse(valueSTRContinue) > 2 || int.Parse(valueSTRContinue) < 1)
        {
            Console.WriteLine("Ops! Valor inválido.");
            Console.Write("Digite um número(1 - Sim/ 2 - Não): ");
            valueSTRContinue = Console.ReadLine();
            continueInput = int.Parse(valueSTRContinue) == 1;
        }
    }

    continueInput = int.Parse(valueSTRContinue) == 1;



} while (continueInput);