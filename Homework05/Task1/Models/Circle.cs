
namespace Task1.Models
{
    public class Circle : Shape
    {
        private int _radius;

        public Circle(string name, string color, int[] position, int radius) : base(name, color, position)
        {
            _radius = radius;
        }
        public override void getArea()
        {
            Console.WriteLine($"Area of the circle with {_radius} radius is: {Math.PI * _radius * _radius}");
        }

        public override void GetPerimetar()
        {
            Console.WriteLine($"Perimeter of the circle with {_radius} is {(Math.PI * _radius * 2)}");
        }

        public override void Move()
        {
            Position[0] += 5;
            Position[1] += 5;
            Console.WriteLine($"The pisition is increasing for position 1: {Position[0]} and for position 2: {Position[1]}");
        }
    }
}
