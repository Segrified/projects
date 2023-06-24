using System;
using System.IO;

//Base parent class for the activiy subclasses
class GoalTracker
{
    private List<Goal> _goals;
    private int _pointsTotal;

    //Creates goal list
    public GoalTracker() {
        _goals = new List<Goal>();
        _pointsTotal = 0;
    }

    //returns total points
    public int GetPoints() {
        return _pointsTotal;
    }

    //creates and adds a goal depending on type
    public void CreateGoal(int choice) {
        if (choice == 1) {
            //Simple type
            SimpleGoal goal = new SimpleGoal();
            goal.Prompt();
            _goals.Add(goal);
        }
        else if (choice == 2) {
            //Eternal type
            EternalGoal goal = new EternalGoal();
            goal.Prompt();
            _goals.Add(goal);
        }
        else if (choice == 3) {
            //Checklist type
            ChecklistGoal goal = new ChecklistGoal();
            goal.Prompt();
            _goals.Add(goal);
        }
    }

    //Writes a line in a given file for each goal
    public void SaveFile() {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename)) {
            outputFile.WriteLine("points/$/" + _pointsTotal);
            for (int i = 0; i < _goals.Count; i++) {
                outputFile.WriteLine(_goals[i].GetSave());
            }
        }
    }

    //Creates goals for each line in a given file
    public void loadFile() {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        //Reads type and passes the line to the goal to change its variables, then adds tot he list
        foreach (string line in lines) {
            string[] parts = line.Split("/$/");
            if (parts[0] == "SimpleGoal"){
                SimpleGoal goal = new SimpleGoal();
                goal.Load(line);
                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal"){
                EternalGoal goal = new EternalGoal();
                goal.Load(line);
                _goals.Add(goal);
            }
            else if (parts[0] == "ChecklistGoal"){
                ChecklistGoal goal = new ChecklistGoal();
                goal.Load(line);
                _goals.Add(goal);
            }
            else if (parts[0] == "points") {
                _pointsTotal = Int32.Parse(parts[1]);
            }
        }
    }

    //Lists goals, including completion status and descriptions
    public void ListGoalsLong() {
        for (int i = 0; i < _goals.Count(); i++) {
            Console.WriteLine((i + 1) + ". [" + _goals[i].getIsComplete() + "] " + _goals[i].GetString());
        }
    }

    //Lists goals by name
    public void ListGoalsShort() {
        for (int i = 0; i < _goals.Count(); i++) {
            Console.WriteLine((i + 1) + ". " + _goals[i].GetName());
        }
    }

    //Tells a goal to accomplish and tells user how many points were gained
    public void AccomplishGoal(int choice) {
        int add = _goals[choice-1].Accomplish();
        _pointsTotal += add;

        Console.WriteLine(add + " points added.");
    }
}