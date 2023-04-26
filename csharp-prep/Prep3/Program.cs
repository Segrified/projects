using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;

        do {
            Random generator = new Random();
            int magicNumber = generator.Next(1, 100);
            int guess = 0;
            int count = 0;

            do {
                count++;

                Console.Write("Guess a number between 1 and 100. ");
                string input = Console.ReadLine();
                guess = int.Parse(input);

                if (guess == magicNumber){
                    if (count == 1){
                        Console.WriteLine("You nailed it first try!");
                    }
                    else {
                        Console.WriteLine("You got it in " + count + " tries!");
                    }
                }
                else if (guess > magicNumber){
                    if (guess < magicNumber + 10){
                        Console.WriteLine("You're just a bit high.");
                    }
                    else {
                        Console.WriteLine("It's lower than that.");
                    }
                }
                else if (guess < magicNumber){
                    if (guess > magicNumber - 10){
                        Console.WriteLine("You're just a bit low.");
                    }
                    else {
                        Console.WriteLine("It's higher than that.");
                    }
                }
            }while (guess != magicNumber);

            Console.Write("Play again? ");
            string playCheck = Console.ReadLine();

            if (playCheck.ToLower() == "yes") {
                play = true;
            }
            else {
                Console.Write("Thanks for playing!");
                play = false;
            }
        }while (play);
    }
}