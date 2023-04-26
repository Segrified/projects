using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number;
        float total = 0;
        int largest = 0;
        List<int> numberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do {
            Console.Write("Enter Number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0){
                numberList.Add(number);
            }
        } while (number != 0);

        for (int i = 0; i < numberList.Count; i++){
            total += numberList[i];

            if (largest < numberList[i]){
                largest = numberList[i];
            }
        }

        Console.WriteLine("The sum is: " + total);
        Console.WriteLine("The average is: " + (total / numberList.Count));
        Console.WriteLine("The largest number is: " + largest);
    }
}