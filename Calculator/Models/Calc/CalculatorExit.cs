namespace Calculators.Models.Calc;

class CalculatorExit : Calculator
{
    public override void Executar()
    {
        base.Executar();
        Console.WriteLine("Tchau tchau :)");
    }
}