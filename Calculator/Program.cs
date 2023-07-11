using Calculators.Models.Calc;

Dictionary<int, Calculator> listCalculators = new()
{
    {1, new CalculatorSum()},
    {2, new CalculatorSub()},
    {3, new CalculatorMult()},
    {4, new CalculatorDiv()},
    {5, new CalculatorExpression()},
    {-1, new CalculatorExit()}
};

void ExibirMenu()
{
    Console.WriteLine("==== Calculadoras ====");

    Console.WriteLine(@"Opção 1: Calculadora de Soma.
Opção 2: Calculadora de Subtração.
Opção 3: Calculadora de Multiplicação.
Opção 4: Calculadora de Divisão.
Opção 5: Calculadora de Expressão.
Opção -1: Sair.");


    System.Console.Write("\nQual Calculadora deseja usar: ");
    string? optionText = Console.ReadLine();
    var option = int.Parse(optionText);

    if (listCalculators.ContainsKey(option))
    {
        Calculator calculator = listCalculators[option];
        calculator.Executar();
        if(option > 0) ExibirMenu();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("\n\nOpção não encontrada.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
}

ExibirMenu();