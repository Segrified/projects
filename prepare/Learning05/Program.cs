using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();

        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle("blue", 3.2, 7);
        Circle circle = new Circle("purple", 9.9);

        list.Add(square);
        list.Add(rectangle);
        list.Add(circle);

        for (int i = 0; i < list.Count; i++) {
            Console.WriteLine("This is a {0} {1} with an area of {2}.", list[i].GetColor(), list[i].GetType(), list[i].GetArea());
        }
    }
}