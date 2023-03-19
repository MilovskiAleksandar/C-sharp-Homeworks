using DogExercise;

Console.WriteLine("Enter the name of the dog");
string name = Console.ReadLine();

Console.WriteLine("Enter the breed of the dog");
string breed = Console.ReadLine();

Console.WriteLine("Enter the color of the dog");
string color = Console.ReadLine();

Dog firstDog = new Dog(name, breed, color);
Console.WriteLine($"Your dog name is: {name}, breed: {breed}, color: {color}\n");

Console.WriteLine("Enter 1 if you want your dog to Eat\n Enter 2 if you want your dog to PLAY\n Enter 3 if you want your dog to CHASE his TAIL");
string inputForMethods = Console.ReadLine();
int input;
bool succes = int.TryParse(inputForMethods, out input);
if (succes)
{
    if (input == 1)
    {
        Console.WriteLine(firstDog.Eat());
    }
    else if (input == 2)
    {
        Console.WriteLine(firstDog.Play());
    }
    else if (input == 3)
    {
        Console.WriteLine(firstDog.ChaseTail());
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}



