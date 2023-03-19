Console.WriteLine("Enter your birth year (month-day-year) in this order");
string input = Console.ReadLine();
DateTime date;

bool success = DateTime.TryParse(input, out date);
if (success)
{
    AgeCalculator(date);
}
else
{
    Console.WriteLine("Invalid INPUT!");
}


int AgeCalculator(DateTime date)
{
    int userAge = DateTime.Now.Year - date.Year;

    if (date > DateTime.Now)
    {
        Console.WriteLine("You cant be born in this date!!");
    }
    else if (date.Day == DateTime.Now.Day && date.Month == DateTime.Now.Month && date.Year == DateTime.Now.Year) // date == DateTime.Now??
    {
        Console.WriteLine("You are born TODAY");
    }
    else
    {
        Console.WriteLine($"You are {userAge} years old");
    }

    return userAge;

}






