using System.ComponentModel;
using System.Data.Common;
using System.Net.Http.Headers;
public class Order
{
    List<Product> _products = new List<Product>();
    Customer _customer;



    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddToOrder(Product product)
    {
        _products.Add(product);
    }

    public void GetPackingLabel()
    {

        foreach (Product product in _products)
        {
            string productInfo = product.GetProductInformation();
            string[] productSplit = productInfo.Split("|");
            string prodName = productSplit[0];
            string prodId = productSplit[1];
            Console.WriteLine($"{prodName} {prodId}");
        }
        
        
    }

    public string GetShippingLable()
    {
        return _customer.GetShippingInfo();
    }

    public int CalculateTotalPrice()
    {
        int shippingCost;
        int productCost = 0;

        if (_customer.LiveInUsa())
        {
            shippingCost = 5;
        }

        else
        {
            shippingCost = 35;
        }

        
        foreach (Product product in _products)
        {
            productCost += product.TotalCost();
        }
        return shippingCost + productCost;
        

    
    }
}