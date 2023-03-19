
int[] inputNumbers = new int[6];
int sum = 0;

for (int i = 0; i < inputNumbers.Length; i++)
{
    Console.WriteLine("Enter integer no." + (i + 1));
    string num = Console.ReadLine();
    int firstNum;
    bool firstSuccess = int.TryParse(num, out firstNum);
    if (firstSuccess)
    {
        inputNumbers[i] = firstNum;
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}
foreach(int evenNumbers in inputNumbers)
{
    if(evenNumbers % 2 == 0)
    {
        sum += evenNumbers;
    }

}
Console.WriteLine("The sum of the even numbers is: " + sum);
