using System;

class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address) {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;

    }

    public override string getFullDetails() {
        return getStandardDetails() + " | Speaker: " + _speaker + " | " + _capacity + " Seating Capacity";
    }
}