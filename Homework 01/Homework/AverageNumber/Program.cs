Console.WriteLine("Enter the First number:");
string firstNumber = Console.ReadLine();
int parsedFirstNumber = int.Parse(firstNumber);


Console.WriteLine("Enter the Second number:");
string secondNumber = Console.ReadLine();
int parsedSecondNumber = int.Parse(secondNumber);

Console.WriteLine("Enter the Third number:");
string thirdNumber = Console.ReadLine();
int parsedThirdNumber = int.Parse(thirdNumber);

Console.WriteLine("Enter the Fourth number:");
string fourthNumber = Console.ReadLine();
int parsedFourthNumber = int.Parse(fourthNumber);

int result = (parsedFirstNumber + parsedSecondNumber + parsedThirdNumber + parsedFourthNumber) / 4;
Console.WriteLine("The average of" + " " + parsedFirstNumber + "," + parsedSecondNumber + "," + parsedThirdNumber + "," + parsedFourthNumber + " " + "is :" + " " + result);