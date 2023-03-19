
using System.Xml.Linq;

namespace Task1.Models
{
    public class Shape
    {
        private string _name;
        private string _color;
        public int[] Position { get; set; }


        public Shape(string name, string color, int[] position)
        {
            Name = name;
            Color = color;
            Position = position;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (string.IsNullOrEmpty(_name)){
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    Console.WriteLine($"The name is {_name}");
                }
            }
        }
        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;

                if (string.IsNullOrEmpty(_color))
                {
                    Console.WriteLine("Invalid color");
                }
                else if (_color.Length < 3)
                {
                    Console.WriteLine("Invalid color");
                }
                else
                {
                    Console.WriteLine($"The value of the color is {_color}");
                }
            }
        }
        public virtual void getArea()
        {
            Console.WriteLine($"There is no special implementation for area");
        }

        public virtual void GetPerimetar()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }

        public virtual void Move()
        {
            Position[0] += 5;
            Position[1] += 5;
            Console.WriteLine($"The pisition is increasing for position 1: {Position[0]} and for position 2: {Position[1]}");
        }
    }
}
