using System;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name) {
        _name = name;
    }

    public void setAddress(string street, string city, string state, string country) {
        _address = new Address(street, city, state, country);
    }

    public bool isUSA() {
        return _address.isUSA();
    }

    public string getName() {
        return _name;
    }

    public string getAddress() {
        return _address.getString();
    }
}