using System.Data;
namespace Calculators.Models.Calc;


class CalculatorExpression : Calculator
{
    public override void Executar()
    {
        base.Executar();
        Console.WriteLine("Exemplo: 3+4*(5*9)");
        Console.Write("Digite a sua expressão mátematica: ");
        string? expressao = Console.ReadLine();

        DataTable dt = new DataTable();
        var expresseionNumbers = dt.Compute(expressao, "");
        if(expresseionNumbers.ToString() == "") expresseionNumbers = 0;
        
        Console.WriteLine($"\nResultado: {expresseionNumbers}");

        Thread.Sleep(3000);
        Console.Clear();
    }
}