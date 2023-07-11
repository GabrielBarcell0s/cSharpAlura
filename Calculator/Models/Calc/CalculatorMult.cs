using Calculators.Models.Utils;

namespace Calculators.Models.Calc;
class CalculatorMult : Calculator
{
    public override void Executar()
    {
        base.Executar();
        Console.WriteLine("==== Calculadora Multiplicadora ====\n");

        var textInput = "Dígite um valor para ser multiplicado: ";
        var textErrorInput = "Valor digitado inválido, por favor dígite um valor: ";

        var ListValue = new InputCheck().ListOfInput(textInput, textErrorInput);

        double multipliedNumbers = 1;

        foreach (var number in ListValue)
        {
            multipliedNumbers *= number;
        }

        Console.WriteLine($"\nResultado: {multipliedNumbers}");
        Thread.Sleep(3000);
        Console.Clear();
    }
}