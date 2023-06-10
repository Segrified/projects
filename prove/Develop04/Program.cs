using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;

        do {
            Console.Clear();
            Console.Write("Menu Options:\n  1. Start Breathing Activity\n  2. Start Reflection Activity\n  3. Start Listing Activity\n  4. Quit\nSelect an option from the menu: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) {
                BreathingActivity activity = new BreathingActivity();

                Console.Clear();
                Console.Write(activity.GetIntro());
                activity.SetTimer(Convert.ToInt32(Console.ReadLine()));

                activity.BreathingLoop();
            }
            else if (choice == 2) {
                ReflectionActivity activity = new ReflectionActivity();

                Console.Clear();
                Console.Write(activity.GetIntro());
                activity.SetTimer(Convert.ToInt32(Console.ReadLine()));

                activity.ReflectionLoop();
            }
            else if (choice == 3) {
                ListingActivity activity = new ListingActivity();

                Console.Clear();
                Console.Write(activity.GetIntro());
                activity.SetTimer(Convert.ToInt32(Console.ReadLine()));

                activity.ListingLoop();
            }
            else if (choice == 4) {
                play = false;
            }
        } while (play == true);
    }
}