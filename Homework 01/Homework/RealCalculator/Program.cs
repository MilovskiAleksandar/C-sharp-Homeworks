Console.WriteLine("Enter the First number:");
string firstNumber = Console.ReadLine();
int parsedFirstNumber = int.Parse(firstNumber);


Console.WriteLine("Enter the Second number:");
string secondNumber = Console.ReadLine();
int parsedSecondNumber = int.Parse(secondNumber);

Console.WriteLine("Enter Operation ( +, - , * , / ) :");
string operation = Console.ReadLine();
char parsedOperation = char.Parse(operation);


//First way
switch (parsedOperation)
{
    case '+':
        Console.WriteLine("The result is: " + (parsedFirstNumber + parsedSecondNumber));
        break;
    case '-':
        Console.WriteLine("The result is: " + (parsedFirstNumber - parsedSecondNumber));
        break;
    case '*':
        Console.WriteLine("The result is: " + (parsedFirstNumber * parsedSecondNumber));
        break;
    case '/':
        Console.WriteLine("The result is: " + (parsedFirstNumber / parsedSecondNumber));
        break;
    default:
        Console.WriteLine("You entered wrong operation");
        break;
}

//Second way

//if (parsedOperation == '+')
//{
//    Console.WriteLine("The result is: " + (parsedFirstNumber + parsedSecondNumber));
//}
//else if (parsedOperation == '-')
//{
//    Console.WriteLine("The result is: " + (parsedFirstNumber - parsedSecondNumber));
//}
//else if (parsedOperation == '*')
//{
//    Console.WriteLine("The result is: " + (parsedFirstNumber * parsedSecondNumber));
//}
//else if (parsedOperation == '/')
//{
//    Console.WriteLine("The result is: " + (parsedFirstNumber / parsedSecondNumber));
//}
//else
//{
//    Console.WriteLine("You entered wrong operation!!");
//}