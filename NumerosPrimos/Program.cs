List<int> Numbers = new(){1,2,3,4,5,7,9,15,113};

foreach (var number in Numbers)
{
    CheckPrimeNumber checkPrimeNumber = new();
    checkPrimeNumber.CheckIfTheNumberIsPrime(number);
}