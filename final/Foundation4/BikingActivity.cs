using System;

class BikingActivity : Activity
{
    private double _speed;

    public BikingActivity(string date, double length, double speed) : base(date, length) {
        _speed = speed;
        _type = "Stationary Bicycles";

    }

    public override double getDistance() {
        return (_speed / 60) * _length;
    }

    public override double getSpeed() {
        return _speed;
    }

    public override double getPace() {
        return 60 / _speed;
    }
}