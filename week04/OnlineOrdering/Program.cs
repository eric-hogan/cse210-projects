using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Flamming Hoop", "0001", 27, 3);

        Console.WriteLine(p1.TotalCost());

        Address a1 = new Address("shady butt", "nowhere", "TN", "Canada");
        Console.WriteLine(a1.GetShippingAddress());

        Customer c1 = new Customer("Stan", "Lee", a1);
        Console.WriteLine(c1);

        Order o1 = new Order();
        Console.WriteLine(o1.CalculateTotalPrice());
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLable());
    }
}