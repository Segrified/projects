using System;

abstract class Activity
{
    protected string _date;
    protected double _length;
    protected string _type;

    public Activity(string date, double length) {
        _date = date;
        _length = length;
    }

    public abstract double getDistance();

    public abstract double getSpeed();

    public abstract double getPace();

    public string getSummary() {
        return _date + " " + _type + " (" + _length + ") - Distance " + getDistance() + " km, Speed: " + getSpeed() + " kph, Pace: " + getPace() + " min per km";
    }
}