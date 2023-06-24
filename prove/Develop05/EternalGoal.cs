using System;

//Eternal type goal class
class EternalGoal : Goal
{
    //adds name
    public EternalGoal() : base() {
        _type = "EternalGoal";
    }

    //Overrides abstract function for unique completion conditions
    public override int Accomplish() {
        return _points;
    }
}