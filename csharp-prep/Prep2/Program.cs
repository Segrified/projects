using System;

class Program
{
    static void Main(string[] args)
    {
        bool pass = false;
        string letter;
        string suffix = "";

        Console.Write("Grade Percentage: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        if (percentage >= 90) {
            letter = "A";
            pass = true;
        }
        else if (percentage >= 80) {
            letter = "B";
            pass = true;
        }
        else if (percentage >= 70) {
            letter = "C";
            pass = true;
        }
        else if (percentage >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        if (percentage < 96 && percentage > 60){
            while (percentage > 9){
                percentage -= 10;
            }

            if (percentage >= 7){
                suffix = "+";
            }
            else if (percentage <= 3){
                suffix = "-";
            }
        }

        Console.Write("Your grade is " + letter + suffix);
        
        if (pass){
            Console.WriteLine(", you passed! Good Job!");
        }
        else {
            Console.WriteLine(", you failed. You'll get the next one.");
        }
    }
}