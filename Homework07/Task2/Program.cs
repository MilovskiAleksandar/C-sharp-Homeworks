using Task2.Domain.Enum;
using Task2.Domain.Models;

List<Animal> animals = new List<Animal>
        {
            new Animal("Bob", "Black", 2, Gender.Male),
            new Animal("Mark", "Brown", 5, Gender.Male),
            new Animal("AliceAlicee", "White", 1, Gender.Female),
            new Animal("Micky", "Green", 3, Gender.Male),
            new Animal("Lisa", "Brown", 4, Gender.Female),
            new Animal("Aloka", "White", 2, Gender.Female)
        };

List<Animal> aged5OrMore = animals.Where(x => x.Age >= 5).ToList();
foreach(var animal in aged5OrMore)
{
    Console.WriteLine($"The name of the dogs whos age is 5 or more: {animal.Name}");
}

List<Animal> dogsNameStartsWithA = animals.Where(x => x.Name.StartsWith("A")).ToList();
foreach (var animal in dogsNameStartsWithA)
{
    Console.WriteLine($"The name that starts with letter A: {animal.Name}");
}

List<Animal> maleBrown = animals.Where(x => x.Gender == Gender.Male && x.Color.ToLower() == "Brown".ToLower()).ToList();
foreach (var animal in maleBrown)
{
    Console.WriteLine($"Animal with gender Male and has color brown: {animal.Name}");
}

Animal nameLongerThanTen = animals.FirstOrDefault(x => x.Name.Length > 10);
if(nameLongerThanTen != null)
{
    Console.WriteLine($"The name with more than 10 characters is: {nameLongerThanTen.Name}");
}
