using System;

class Square : Shape{
    private double _side;

    public Square(string color, double side) : base(color) {
        _side = side;
        Console.WriteLine("Child Class");
    }

    public  override double GetArea() {
        return _side * _side;
    }
}