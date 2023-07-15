using System;

class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string date, double length, double laps) : base(date, length) {
        _laps = laps;
        _type = "Swimming";
    }

    public override double getDistance() {
        return (_laps * 50) / 1000;
    }

    public override double getSpeed() {
        return (getDistance() / _length) * 60;
    }

    public override double getPace() {
        return _length / getDistance();
    }
}