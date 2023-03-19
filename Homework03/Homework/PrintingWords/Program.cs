Console.WriteLine("Enter a sentence");
string[] input = Console.ReadLine().Split(" ");
foreach (string words in input)
{
    Console.WriteLine(words);
}