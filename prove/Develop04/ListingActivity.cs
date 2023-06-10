using System;

//Base parent class for the activiy subclasses
class ListingActivity : Activity
{
    List<string> _prompts = new List<string>();

    public ListingActivity() : base() {
        _activityType = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public string GetPrompt() {
        Random pick = new Random();
        string randPrompt = _prompts[pick.Next(0, 4)];
        return randPrompt;
    }

    public void ListingLoop() {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        PauseSpinner(5);

        Console.Write("List as many responses as you can to the following prompt:\n\n --- " + GetPrompt() + " ---\nYou may begin in: ");
        PauseCountdown(7);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timer);
        DateTime currentTime = DateTime.Now;

        int count = 0;

        do {
        Console.Write("> ");
        Console.ReadLine();
        count++;
        currentTime = DateTime.Now;
        } while (currentTime < futureTime);

        Console.WriteLine("You listed " + count + " items.");

        Console.WriteLine("\nWell Done!");
        PauseSpinner(5);

        Console.WriteLine("\n\nYou have completed another " + _timer + " seconds of the " + _activityType + ".");
        PauseSpinner(5);
    }
}