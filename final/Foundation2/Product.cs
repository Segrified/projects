using System;

class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity) {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string getName() {
        return _name;
    }

    public string getId() {
        return _id;
    }

    public int getQuantity() {
        return _quantity;
    }

    public double getPrice() {
        return _price;
    }

    public double getTotal() {
        return _price * _quantity;
    }

    public string getString() {
        return _name + " | " + _id + " | " + _price + " | " + _quantity + " | " + getTotal();
    }
}