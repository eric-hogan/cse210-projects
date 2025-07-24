using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Flamming Hoop", "0001", 27, 3);

        Address a1 = new Address("shady butt", "nowhere", "TN", "USA");

        Customer c1 = new Customer("Stan", "Lee", a1);

        Order o1 = new Order(c1);
        o1.AddToOrder(p1);
        Console.WriteLine(o1.GetShippingLable());
        o1.GetPackingLabel();
        Console.WriteLine(o1.CalculateTotalPrice());
        // 
    }
}