List<int> numbers = new() {};

for(int i = 0; i <= 100;i++)
{
    numbers.Add(i);
}

for(int i = 0;i < numbers.Count; i+=2)
{
    Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\n");
foreach(int number in numbers)
{
    if (number % 2 == 0) Console.Write($"{number} ");
}