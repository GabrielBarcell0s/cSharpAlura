class Pyramid
{
    public int InputCheckerInt()
    {
        Console.WriteLine("Tamanho Máximo é 8.");
        Console.WriteLine("Tamanho Mínimo é 3.\n");
        string? sizeText;
        int size;

        do{
            Console.Write("Qual tamanho de Pirâmide você deseja ver: ");
            sizeText = Console.ReadLine();

            while(string.IsNullOrEmpty(sizeText) || !(int.TryParse(sizeText, out _))){
                Console.Write("Valor invalido, Digite o tamanho novamente: ");
                sizeText = Console.ReadLine();
            }

            size = int.Parse(sizeText);
        } while (size < 3 || size > 8);

        return size;
    }
    public List<int>CreateListInt(int size)
    {
        List<int> listInt = new(){};
        int value = 1;

        for (int i = 0; i < size; i++)
        {
            listInt.Add(value);
            value += 2;
        }

        return listInt;
    }
    public void CreatePyramidAllignLeft()
    {
        var size = InputCheckerInt();
        var amountHashtags = CreateListInt(size);
        string texto = string.Empty;

        for (int i = 0; i < size; i++)
        {
            texto = texto.PadLeft(amountHashtags[i], '#');
            System.Console.WriteLine(texto);
        }

    }

    public void CreatePyramidAllignRight()
    {
        int size = InputCheckerInt();
        var amountHashtags = CreateListInt(size);
        string texto = string.Empty;
        

        for (int i = 0; i < size; i++)
        {
            string spaces = string.Empty;
            texto = texto.PadLeft(amountHashtags[i], '#');
            if(texto.Length != amountHashtags[size-1]){
                int amount =  amountHashtags[size-1] - texto.Length;
                spaces = spaces.PadLeft(amount, ' ');
            }
            System.Console.WriteLine(spaces+texto);
        }
    }

    public void CreatePyramidAllignCenter()
    {
        int size = InputCheckerInt();
        var amountHashtags = CreateListInt(size);
        string texto = string.Empty;
        
        for (int i = 0; i < size; i++)
        {
            string spacesLeft = string.Empty;
            string spacesRight = string.Empty;
            texto = texto.PadLeft(amountHashtags[i], '#');
            if(texto.Length != amountHashtags[size-1]){
                int amount =  amountHashtags[size-1] - texto.Length;
                spacesLeft = spacesLeft.PadLeft(amount/2, ' ');
                spacesRight = spacesRight.PadRight(amount/2, ' ');
            }
            System.Console.WriteLine(spacesLeft+texto+spacesRight);
        }
    }
}