


var fibonacciNumbers = new List<int> { 1, 1 };

while (fibonacciNumbers.Count < 20)
{
    int previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    int previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}

foreach (var fibonacciNumber in fibonacciNumbers)
{
    Console.WriteLine(fibonacciNumber);

}

