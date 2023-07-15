using System;

class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address) {
        _type = "Reception";
        _email = email;

    }

    public override string getFullDetails() {
        return getStandardDetails() + " | RSVP Email: " + _email;
    }
}