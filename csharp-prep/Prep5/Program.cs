using System;

class Program
{
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string input = Console.ReadLine();
        return input;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int SquareNumber(int number){
        return number * number;
    }

    static void DisplayResult(string name, int sqNumber){
        Console.WriteLine(name + ", the square of your number is " + sqNumber);
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqNumber = SquareNumber(number);
        DisplayResult(name, sqNumber);
    }
}