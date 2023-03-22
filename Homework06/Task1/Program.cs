Queue<int> queue = new Queue<int>();

while (true)
{
    Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    int number;
    bool succes = int.TryParse(input, out number);
    
    if (succes)
    {
        queue.Enqueue(number);
        Console.Write("Press any key to try again or X to exit: ");
        string output = Console.ReadLine();
        if (output.Equals("X", StringComparison.InvariantCultureIgnoreCase))
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input");
    }

}

while (queue.Count > 0)
{
    int result = queue.Dequeue();
    Console.WriteLine(result);
}


