using Calculators.Models.Utils;

namespace Calculators.Models.Calc;
class CalculatorSub : Calculator
{
    public override void Executar()
    {
        base.Executar();
        Console.WriteLine("==== Calculadora de Subtração ====\n");

        var textInput = "Dígite um valor para ser subtraido: ";
        var textErrorInput = "Valor digitado inválido, por favor dígite um valor: ";

        var ListValue = new InputCheck().ListOfInput(textInput, textErrorInput);

        double subtractedNumbers = ListValue[0];
        ListValue.RemoveAt(0);

        foreach (var number in ListValue)
        {
            subtractedNumbers -= number;
        }

        Console.WriteLine($"\nResultado: {subtractedNumbers}");
        Thread.Sleep(3000);
        Console.Clear();
    }
}