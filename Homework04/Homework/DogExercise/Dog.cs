
namespace DogExercise
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public Dog()
        {

        }
        public Dog(string name, string breed, string color)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name value");
            }
            else
            {
                Name = name;
            }

            if (string.IsNullOrEmpty(breed))
            {
                Console.WriteLine("Invalid breed value");
            }
            else
            {
                Breed = breed;
            }
            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid color value");
            }
            else
            {
                Color = color;
            }

            
        }

        public string Eat()
        {
            return $"{Name} is now eating";
        }
        public string Play()
        {
            return $"{Name} is now playing";
        }
        public string ChaseTail()
        {
            return $"{Name} is now chasing his tail";
        }
    }
}
