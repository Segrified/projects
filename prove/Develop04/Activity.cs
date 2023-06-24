using System;

//Base parent class for the activiy subclasses
class Activity
{
    protected int _timer;
    protected string _activityType;
    protected string _description;

    public Activity() {
        Console.WriteLine("Base Class");
    }

    //gives the intro format as a string
    public string GetIntro() {
        return "Welcome to the " + _activityType + ".\n\n" + _description + "\n\nHow long, in seconds, would you like for your session? ";
    }

    //gives the ending format as a string
    public string GetEnding() {
        return "You have completed another " + _timer + " seconds of the " + _activityType + ".";
    }

    //sets the timer value
    public void SetTimer(int time) {
        _timer = time;
    }

    //uses the sleep function to pause the program, as well as gives a spinner animation
    public void PauseSpinner(int time) {
        for (int i = 0; i < time; i++) {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b/");
            Thread.Sleep(250);
            Console.Write("\b \b-");
            Thread.Sleep(250);
            Console.Write("\b \b\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    //uses the sleep function to pause the program, as well as gives a countdown
    public void PauseCountdown(int time) {
        for (int i = time; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}