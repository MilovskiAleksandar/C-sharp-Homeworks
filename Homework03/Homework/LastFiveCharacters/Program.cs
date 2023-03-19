Console.WriteLine("Enter some word to see his last 5 characters");
string input = Console.ReadLine();
if(input.Length < 5)
{
    Console.WriteLine("Your word must have 5 characters!!");
} 
else
{
    string lastFiveCharacters = input.Substring(input.Length - 5);
    Console.WriteLine($"The last 5 characters of your word are: {lastFiveCharacters}");
}