using Calculators.Models.Utils;

namespace Calculators.Models.Calc;
class CalculatorDiv : Calculator
{
    public override void Executar()
    {
        base.Executar();
        Console.WriteLine("==== Calculadora Divisora ====\n");

        var textInput = "Dígite um valor para ser Dividido: ";
        var textErrorInput = "Valor digitado inválido, por favor dígite um valor: ";

        var ListValue = new InputCheck().ListOfInput(textInput, textErrorInput);

        double dividedNumbers = ListValue[0];
        ListValue.RemoveAt(0);

        foreach (var number in ListValue)
        {
            dividedNumbers /= number;
        }

        Console.WriteLine($"\nResultado: {dividedNumbers}");
        Thread.Sleep(3000);
        Console.Clear();
    }
}