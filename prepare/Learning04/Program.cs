using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Tucker Giovo", "Pi Calculations", "3", "1-4");
        WritingAssignment assignment2 = new WritingAssignment("Tucker Giovo", "Programming", "The History of This Program");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}