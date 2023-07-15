using System;

abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;

    public Event(string title, string description, string date, string time, Address address) {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string getStandardDetails() {
        return _title + ": " + _description + " | " + _date + ", " + _time + " | " + _address;
    }

    public string getShortDescription() {
        return _type + " | " + _title + " | " + _date;
    }

    public abstract string getFullDetails();
}