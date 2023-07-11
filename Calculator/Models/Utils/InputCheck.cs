namespace Calculators.Models.Utils;

using System.Globalization;

class InputCheck
{
    public double InputCheckerDouble(string textMain, string textError)
    {
        string? inputText;
        double doubleInput;
        CultureInfo culture = CultureInfo.InvariantCulture;

        Console.Write(textMain);
        inputText = Console.ReadLine();

        while (string.IsNullOrEmpty(inputText) || !(double.TryParse(inputText, NumberStyles.Number, culture, out doubleInput)))
        {
            Console.Write(textError);
            inputText = Console.ReadLine();
        }

        return doubleInput;
    }

    public List<double> ListOfInput(string textInput,string textError)
    {
        var continueInput = true;
        List<double> listOfInput = new();

        while(continueInput){
            
            var inputDoubleString = InputCheckerDouble(textInput, textError);
            listOfInput.Add(inputDoubleString);

            Console.Write("Deseja adicionar mais um número? (1-Sim, 0-Não)");
            var continueInputString = Console.ReadLine();
            var continueInputInt =  Convert.ToInt16(continueInputString);
            continueInput = Convert.ToBoolean(continueInputInt);
        }

        return listOfInput;
    }
}