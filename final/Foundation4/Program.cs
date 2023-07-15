using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        RunningActivity running = new RunningActivity("07 July 2023", 30, 5);
        BikingActivity biking = new BikingActivity("08 July 2023", 60, 20);
        SwimmingActivity swimming = new SwimmingActivity("09 July 2023", 45, 30);

        _activities.Add(running);
        _activities.Add(biking);
        _activities.Add(swimming);

        for (int i = 0; i < _activities.Count(); i++) {
            Console.WriteLine(_activities[i].getSummary());
        }
    }
}