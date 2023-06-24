using System;

//Simple type goal class
class SimpleGoal : Goal
{
    //adds name
    public SimpleGoal() : base() {
        _type = "SimpleGoal";
    }

    //Overrides abstract function for unique completion conditions
    public override int Accomplish() {
        if (!_isComplete) {
            _isComplete = true;
            return _points;
        }
        else {
            return 0;
        }
    }
}