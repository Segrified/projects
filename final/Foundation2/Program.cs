using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Tucker Giovo");
        Customer customer2 = new Customer("Logan Shimazaki");

        customer1.setAddress("5591 S 3400 W", "Roy", "Utah", "USA");
        customer2.setAddress("52-21 Arashiyama Tanigatsujikocho", "Kyoto", "Nishikyo Ward", "Japan");

        Order order1 = new Order(customer1);

        Product item1 = new Product("SD Card 128GB", "H3JK6C99", 11.99, 1);
        order1.addItem(item1);

        Product item2 = new Product("Airbrush Cleaner 16oz", "NU555D9W", 13.99, 1);
        order1.addItem(item2);

        Product item3 = new Product("Acrylic Paint 6oz", "P24G9DDD", 1.99, 6);
        order1.addItem(item3);

        order1.printPackingLabel();
        order1.printShippingLabel();
        Console.WriteLine("Total: " + order1.getTotal() + "\n");


        Order order2 = new Order(customer2);

        Product item4 = new Product("PLA 3D Printer Filament", "J8JDTY54", 18.99, 2);
        order2.addItem(item4);

        Product item5 = new Product("Steel 3D Printer Nozzles 5-pack", "PP0V87C9", 8.55, 1);
        order2.addItem(item5);

        Product item6 = new Product("4x2mm Neodymium Magnets 200pc", "SS3G6J12", 8.80, 2);
        order2.addItem(item6);

        order2.printPackingLabel();
        order2.printShippingLabel();
        Console.WriteLine("Total: " + order2.getTotal() + "\n");

    }
}