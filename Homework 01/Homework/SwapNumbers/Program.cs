Console.WriteLine("Input the First number:");
string firstNumber = Console.ReadLine();
int parsedFirstNumber = int.Parse(firstNumber);


Console.WriteLine("Input the Second number:");
string secondNumber = Console.ReadLine();
int parsedSecondNumber = int.Parse(secondNumber);

Console.WriteLine("After Swapping: ");
int temporaryNumber = parsedFirstNumber;
parsedFirstNumber = parsedSecondNumber;
Console.WriteLine("First Number: " + parsedFirstNumber);

parsedSecondNumber = temporaryNumber;
Console.WriteLine("Second Number: " + parsedSecondNumber);
