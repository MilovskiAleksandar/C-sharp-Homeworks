Console.WriteLine("Enter a sentence");
string[] input = Console.ReadLine().Split(" ");
string largestWord = "";
foreach(string word in input)
{
    if(word.Length > largestWord.Length)
    {
        largestWord = word;
    }
}
Console.WriteLine($"The largest word in the sentence is: {largestWord}");