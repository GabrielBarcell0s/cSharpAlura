class CreateFibonacciSequence
{
    public string FibonacciGenerator(int quant){
        int firstValue = 0;
        int storageFirstValue;
        int secondValue = 1;
        
        string fibonacciText = string.Empty;

        for(var i = 0; i < quant; i++){
            fibonacciText += $"{firstValue}";
            storageFirstValue = firstValue;
            firstValue = secondValue;
            secondValue = storageFirstValue + secondValue; 
        } 

        return fibonacciText;
    }
}