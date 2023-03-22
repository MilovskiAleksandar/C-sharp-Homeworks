
using Task2.Domain.Enum;

namespace Task2.Domain.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public Animal(string name, string color, int age, Gender gender)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Invalid input for name");
            }
            Name = name;
            if(string.IsNullOrWhiteSpace(color))
            {
                throw new Exception("Invalid input for color");
            }
            if(color.Length < 3)
            {
                throw new Exception("Color by this name is not possible");
            }
            Color = color;
            Age = age;
            Gender = gender;
        }
    }
}
