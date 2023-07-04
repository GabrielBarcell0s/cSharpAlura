using System.Globalization;
class CalculateChangeMoney
{
    private double InputCheckerDouble(string textMain, string textError)
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
    public void CalculateChange()
    {
        string productTextMain = "Valor do Produto: ";
        string moneyInsertText = "Valor Pago: ";
        string textError = "Tipo de valor incorreto. Por favor digite um valor: ";

        double productValue = InputCheckerDouble(productTextMain, textError);
        double amountPaid = InputCheckerDouble(moneyInsertText, textError);
        double changeMoney;

        while (amountPaid < productValue)
        {
            System.Console.WriteLine("Valor pago é menor que o valor do Produto: Dígite o mesmo valor ou Superior: ");
            amountPaid = InputCheckerDouble(moneyInsertText, textError);
        }

        changeMoney = amountPaid - productValue;
        double changeMoneyText = changeMoney;

        Dictionary<double, int> billsForChange = new(){
            {200, 0},{100, 0},{50, 0},{20, 0},{10, 0},{5, 0},{2, 0},{1, 0},{.25, 0},{.10, 0},{.05, 0},{.01,0}
        };

        Dictionary<double, string> listNameBanknotes = new(){
        {200,"Dozentos Reais"}, {100, "Cem Reais"}, {50,"Cinquenta Reais"}, {20, "Vinte Reais"}, {10, "Dez Reais"}, {5,"Cinco Reais"}, {2, "Dóis Reais"}, {1,"Um Real"}, {.25, "Vinte e Cinco Centavos"}, {.10,"Dez Centavos"}, {.05, "Cinco Centavos"}, {.01, "Um Centavo"}
        };

        foreach (var banknotes in billsForChange)
        {
            while ((changeMoney - banknotes.Key) > 0)
            {
                changeMoney -= banknotes.Key;
                billsForChange[banknotes.Key] += 1;
            }
        }

        Console.WriteLine($"\nTroco: R${changeMoneyText}\n");
        foreach (var banknotes in billsForChange)
        {
            Console.WriteLine($"{listNameBanknotes[banknotes.Key]}: {banknotes.Value}");
        }
        Console.WriteLine();
    }
}