class CheckPrimeNumber
{
    public void CheckIfTheNumberIsPrime(int value)
    {
        var itsPrime = false;
        List<int> primeList = new(){2,3,5,7,11};
        
        var numberOfDivisions = 0;

        foreach (var number in primeList){
            var lastNumberList = primeList[primeList.Count-1];

            if(number == value){itsPrime = true; break;}
            if(numberOfDivisions < 1 && value != 1){
                numberOfDivisions = (value % 1 == 0) ? numberOfDivisions + 1 : numberOfDivisions;
                numberOfDivisions = (value % value == 0) ? numberOfDivisions + 1 : numberOfDivisions;
            }
            else if(numberOfDivisions < 1 && value == 1){
                numberOfDivisions = (value % value == 0) ? numberOfDivisions + 1 : numberOfDivisions;
            }

            numberOfDivisions = (value % number == 0) ? numberOfDivisions + 1 : numberOfDivisions;

            if(numberOfDivisions > 2)
            {
                itsPrime = false; 
                break;
            }
            else if(numberOfDivisions == 2 && number == lastNumberList)
            {
                itsPrime = true;
            }
            else{
                itsPrime = false;
            }
        } 

        if(itsPrime){
            System.Console.WriteLine($"O número {value} é Primo");
        }
        else{
             System.Console.WriteLine($"O número {value} não é Primo");
        }
    }
}