using System;

//Child of Activity Class, loops a breathe in and breathe out prompt for the duration
class BreathingActivity : Activity
{
    public BreathingActivity() : base() {
        _activityType = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Console.WriteLine("Child Class");
    }

    //Loops the breathing activity for the given duration
    public void BreathingLoop() {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        PauseSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timer);
        DateTime currentTime = DateTime.Now;

        do {
        Console.Write("\n\nBreathe in...");
        PauseCountdown(3);
        Console.Write("\nNow Breathe out...");
        PauseCountdown(3);
        currentTime = DateTime.Now;
        } while (currentTime < futureTime);

        Console.WriteLine("\n\nWell Done!");
        PauseSpinner(5);

        Console.WriteLine("\n\nYou have completed another " + _timer + " seconds of the " + _activityType + ".");
        PauseSpinner(5);
    }
}