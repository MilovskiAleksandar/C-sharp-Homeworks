Console.WriteLine("Enter number to calculate sum of the digits");
string inputString = Console.ReadLine();
int number;
bool success = int.TryParse(inputString, out number);
if (success)
{
    int sumOfDigits = SumOfDigits(number);
    Console.WriteLine(sumOfDigits);
}
else
{
    Console.WriteLine("Invalid input");

}
int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digits = number % 10;
        sum += digits;
        number /= 10;
    }
    return sum;
}
