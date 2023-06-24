using System;

//Base parent class for the goal subclasses
abstract class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal() {
        _isComplete = false;
    }

    //gives the name and description
    public virtual string GetString() {
        return _name + " (" + _description + ")";
    }

    //gives just the name
    public string GetName() {
        return _name;
    }

    //prompts for each variable value
    public virtual void Prompt() {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Int32.Parse(Console.ReadLine());
    }

    //abstract function for child classes to modify
    public abstract int Accomplish();

    //Returns either an X or blank space for the checkbox showing completion
    public string getIsComplete() {
        if (_isComplete) {
            return "X";
        }
        else {
            return " ";
        }
    }

    //Gives variable information in save format
    public virtual string GetSave() {
        return _type + "/$/" + _name + "/$/" + _description + "/$/" + _points + "/$/" + _isComplete + "/$/-1/$/-1/$/-1";
    }

    //Sets variables based on a line loaded from a save file
    public virtual void Load(string line) {
        string[] parts = line.Split("/$/");

        _type = parts[0];
        _name = parts[1];
        _description = parts[2];
        _points = Int32.Parse(parts[3]);

        if (parts[4] == "True") {
            _isComplete = true;
        }
        else {
            _isComplete = false;
        }
    }
}