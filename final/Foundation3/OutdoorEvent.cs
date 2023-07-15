using System;

class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address) {
        _type = "Outdoor Gathering";
        _weather = weather;

    }

    public override string getFullDetails() {
        return getStandardDetails() + " | Expected Weather: " + _weather;
    }
}