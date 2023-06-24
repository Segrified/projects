using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;
        GoalTracker tracker = new GoalTracker();

        do {
            Console.Write("\nYou have " + tracker.GetPoints() + " points.\n\nMenu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
            int input = Int32.Parse(Console.ReadLine());

            if (input == 1) {
                Console.Write("\nThe types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ");
                int choice = Int32.Parse(Console.ReadLine());
                tracker.CreateGoal(choice);
            }
            if (input == 2) {
                Console.WriteLine("The goals are:");
                tracker.ListGoalsLong();
            }
            if (input == 3) {
                tracker.SaveFile();
            }
            if (input == 4) {
                tracker.loadFile();
            }
            if (input == 5) {
                Console.WriteLine("\nThe goals are:");
                tracker.ListGoalsShort();
                Console.Write("Which goal did you accomplish? ");
                int choice = Int32.Parse(Console.ReadLine());
                tracker.AccomplishGoal(choice);
            }
            if (input == 6) {
                Console.WriteLine("Thank you. Goodbye.");
                play = false;
            }
        } while (play);
    }
}