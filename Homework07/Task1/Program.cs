List<int> tenNumbers = new List<int> { 2,5,7,10,23,25,28,30,43,51 };

List<int> squaresOfNumbers = tenNumbers.Select(x => x * x).ToList();

foreach (int number in squaresOfNumbers)
{
    Console.WriteLine(number);
}