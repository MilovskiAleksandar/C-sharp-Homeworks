using Task1.Models;
int[] position = { 0, 0 };
Shape shape = new Shape("Shape", "Black", position);
shape.getArea();
shape.GetPerimetar();
shape.Move();

Rectangle rectangle = new Rectangle("Rectangle", "Red", position, 15, 20);
rectangle.getArea();
rectangle.GetPerimetar();
rectangle.Move();

Circle circle = new Circle("Circle", "Green", position, 60);
circle.getArea();
circle.GetPerimetar();
circle.Move();  

