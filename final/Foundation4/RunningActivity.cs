using System;

class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double length, double distance) : base(date, length) {
        _distance = distance;
        _type = "Running";
    }

    public override double getDistance() {
        return _distance;
    }

    public override double getSpeed() {
        return (_distance / _length) * 60;
    }

    public override double getPace() {
        return _length / _distance;
    }
}