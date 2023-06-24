using System;

//Checklist type goal class
class ChecklistGoal : Goal
{
    private int _bonus;
    private int _amount;
    private int _marks;

    //adds _marks variable and sets name
    public ChecklistGoal() : base() {
        _marks = 0;
        _type = "ChecklistGoal";
    }

    //Overrides parent function to give different format
    public override string GetString() {
        return _name + " (" + _description + ") -- Currently completed: " + _marks + "/" + _amount;
    }

    //Overrides parent class to add more prompts for addisional variables
    public override void Prompt() {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Int32.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _amount = Int32.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = Int32.Parse(Console.ReadLine());
    }

    //Overrides abstract function for unique completion conditions
    public override int Accomplish() {
        int current = 0;
        if (!_isComplete) {
            _marks++;
            current += _points;
            if (_marks == _amount) {
                _isComplete = true;
                current += _bonus;
            }
        }
        return current;
    }

    //Overrides parent function for additional information in save line
    public override string GetSave() {
        return _type + "/$/" + _name + "/$/" + _description + "/$/" + _points + "/$/" + _isComplete + "/$/" + _bonus + "/$/" + _amount + "/$/" + _marks;
    }

    //Overrides parent class to load additional variables
    public override void Load(string line) {
        string[] parts = line.Split("/$/");

        _type = parts[0];
        _name = parts[1];
        _description = parts[2];
        _points = Int32.Parse(parts[3]);

        if (parts[4] == "true") {
            _isComplete = true;
        }
        else {
            _isComplete = false;
        }

        _bonus = Int32.Parse(parts[5]);
        _amount = Int32.Parse(parts[6]);
        _marks = Int32.Parse(parts[7]);        
    }
}