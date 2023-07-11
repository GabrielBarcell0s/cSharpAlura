using Calculators.Models.Utils;

namespace Calculators.Models.Calc;
class CalculatorSum : Calculator
{
    public override void Executar()
    {
        base.Executar();
        Console.WriteLine("==== Calculadora Soma ====\n");

        var textInput = "Dígite um valor para ser somado: ";
        var textErrorInput = "Valor digitado inválido, por favor dígite um valor: ";

        var ListValue = new InputCheck().ListOfInput(textInput, textErrorInput);

        double summedNumbers = 0;

        foreach (var number in ListValue)
        {
            summedNumbers += number;
        }

        Console.WriteLine($"\nResultado: {summedNumbers}");
        Thread.Sleep(3000);
        Console.Clear();
    }
}