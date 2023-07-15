using System;

class Order
{
    private Customer _customer;
    private List<Product> _items = new List<Product>();

    public Order(Customer customer) {
        _customer = customer;
    }

    public void addItem(Product item) {
        _items.Add(item);
    }

    public void printPackingLabel() {
        Console.WriteLine(_items.Count() + " Item(s):");

        for (int i = 0; i < _items.Count(); i++) {
            Console.WriteLine(_items[i].getName() + " | " + _items[i].getId() + " | x" + _items[i].getQuantity());
        }

        Console.WriteLine();
    }

    public void printShippingLabel() {
        Console.WriteLine(_customer.getName() + "\n" + _customer.getAddress());
        Console.WriteLine();
    }

    public string getTotal() {
        double total = 0;

        for (int i = 0; i < _items.Count(); i++) {
            total += _items[i].getTotal();
        }

        return "$" + total;
    }
}