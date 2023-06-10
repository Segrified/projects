using System;

//Base parent class for the activiy subclasses
class ReflectionActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectionActivity() : base() {
        _activityType = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("ow can you keep this experience in mind in the future?");
    }

    public string GetPrompt() {
        Random pick = new Random();
        string randPrompt = _prompts[pick.Next(0, 3)];
        return randPrompt;
    }

    public string GetQuestion() {
        Random pick = new Random();
        string randQuestion = _questions[pick.Next(0, 3)];
        return randQuestion;
    }

    public void ReflectionLoop() {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        PauseSpinner(5);

        Console.WriteLine("Consider the following prompt:\n\n --- " + GetPrompt() + " ---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        PauseCountdown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timer);
        DateTime currentTime = DateTime.Now;

        do {
        Console.Write("> " + GetQuestion() + " ");
        PauseSpinner(5);
        Console.WriteLine();
        currentTime = DateTime.Now;
        } while (currentTime < futureTime);

        Console.WriteLine("\n\nWell Done!");
        PauseSpinner(5);

        Console.WriteLine("\n\nYou have completed another " + _timer + " seconds of the " + _activityType + ".");
        PauseSpinner(5);
    }
}