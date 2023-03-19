
namespace Task1.Models
{
    public class Rectangle : Shape
    {
        private int _sideA;
        private int _sideB;

        public Rectangle(string name, string color, int[] position,  int firstSide, int secondSide) : base(name,color, position)
        {
            _sideA = firstSide;
            _sideB = secondSide;
        }

        public override void getArea()
        {
            Console.WriteLine($"The area have sideA: {_sideA}, and sideB: {_sideB} and have area of {(_sideA * _sideB)}");
        }

        public override void GetPerimetar()
        {
            Console.WriteLine($"Perimeter of rectangle with sides {_sideA} and {_sideB} is {(_sideA + _sideB) * 2}");
        }

        public override void Move()
        {
            Position[0] += 5;
            Position[1] += 5;
            Console.WriteLine($"The pisition is increasing for position 1: {Position[0]} and for position 2: {Position[1]}");
        }

    }
}
