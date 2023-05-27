using System;

class Program
{
    static void Main(string[] args)
    {
        string input;

        Journal journal = new Journal();

        do {
            Console.WriteLine(Int32.Parse(num));
            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            input = Console.ReadLine();

            if (input == "1") {
                //Write
                journal.makeEntry();
            }
            else if (input == "2") {
                //Display
                journal.display();
            }
            else if (input == "3") {
                //Load
                journal.loadEntry();
            }
            else if (input == "4") {
                //Save
                journal.saveEntry();
            }
            else if (input == "5") {
                //Quit
                //No function, just makes false input detection easier
            }
            else {
                //False Input
                Console.WriteLine("Sorry, I don't understand.");
            }
        } while (input != "5");
    }
}